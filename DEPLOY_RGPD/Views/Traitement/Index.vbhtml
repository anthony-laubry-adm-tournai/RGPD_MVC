@ModelType IEnumerable(Of RGPD_MVC.Traitement)
@Code
    ViewData("Title") = "Liste des traitements"
    Dim currentUsr As Utilisateur = CType(Session("Utilisateur"), Utilisateur)
End Code

<style>
.ui-tabs .ui-tabs-nav li a
 {
    font-size:15pt !important;
}

#test-2.ui-tabs-active{
    background-color:#F14E56;
    border:#F14E56;
}
</style>

@code
    Select Case currentUsr.Role.Id

        Case 1, 2
            'agent et contact

        Case 3
            'DPD

    End Select
End Code

<div id="tabs">
    <ul>
        <li><a href="#tabs-1">Registre des Traitements</a></li>
        <li id="test-2"><a href="#tabs-2">Registre des Incidents</a></li>
    </ul>

    <div id="tabs-1" style="max-width:1500px;width:100%;">
        @code
            @Using (Html.BeginForm("Index", "Traitement", FormMethod.Post))
                @<div style="display:inline-block;">

                    @Html.DropDownList("triEtat", _
                           New SelectList(New List(Of String)(New String() {"Tout voir", _
                                                                            "Traitement à modifier", _
                                                                            "Traitement à contrôler", _
                                                                            "En attente DPO", _
                                                                            "Traitement valide"}), "Tout voir"), _
                           htmlAttributes:=New With {.class = "form-control", .onchange = "this.form.submit();"})
                </div>
                If currentUsr.IdRole = 3 Then
                @<div style="display:inline-block;">
                    @Html.DropDownList("TriService", _
                           New SelectList(CType(ViewBag.Service, List(Of Service)), "Id", "Libelle"), _
                           htmlAttributes:=New With {.class = "form-control", .onchange = "this.form.submit();"})
                </div>
                End If
                @<br />
            End Using
        End Code

        <table class="table">
            <tr>
                <th>
                    @Html.DisplayName("État")
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Nom)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.AgentEncodeur)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.AgentContact)
                </th>
                <th>Désactiver</th>
                <th></th>
            </tr>

            @For Each item In Model
                @If item.IsActif Then
                    @<tr>
                        <td>
                            @If item.IsValid Then
                                @<div class='isValid' title='Est valide' style="margin-top:20px;"></div>
                            ElseIf item.ToModify Then
                                @<div class='modif' title='A modifier' style="margin-top:20px;"></div>
                            ElseIf item.ToControlContact Then
                                @<div class='toBeControledContact' style="margin-top:20px;" title='En attente de validation par le Contact RGPD du service'></div>
                            ElseIf item.ToControlDPD Then
                                @<div class='toBeControledDPD' style="margin-top:20px;" title='En attente de validation par le/la DPO'></div>
                            End If
                        </td>
                        <td style="font-weight:bold;font-size:17px;">
                            <div style="margin-top:6.5px;">@Html.DisplayFor(Function(modelItem) item.Nom)</div>
                        </td>
                        <td style="font-weight:bold;font-size:17px;">
                            <div style="margin-top:6.5px;">@Html.DisplayFor(Function(modelItem) item.AgentEncodeur)</div>
                        </td>
                        <td style="font-weight:bold;font-size:17px;">
                            <div>@Html.DisplayFor(Function(modelItem) item.AgentContact)</div>
                        </td>
                        <td style="font-weight:bold;font-size:17px;">
                            <div>@Html.DisplayFor(Function(modelItem) item.DateCrea)</div>
                        </td>
                        <td style="font-weight:bold;font-size:12px;">
                            @If item.IsActif Then
                                @<div style="margin-top:10px;">@Html.ActionLink("Désactiver", "Desactive", New With {.id = item.Id}, New With {.class = "desactive"})</div>
                            End If
                        </td>
                        <td style="font-weight:bold;padding-left:5px;">
                            @If currentUsr.Role.Libelle.ToLower.Equals("agent") Then
                                @If item.ToModify Then
                                    @<div style="margin-top:10px;">@Html.ActionLink("Éditer", "Edit", New With {.id = item.Id})</div>
                                ElseIf item.ToControlContact OrElse item.ToControlDPD OrElse item.IsValid Then
                                    @<div style="margin-top:10px;"> @Html.ActionLink("Voir", "Details", New With {.id = item.Id})</div>
                                End If
                            ElseIf currentUsr.Role.Libelle.ToLower.Equals("contact") Then
                                @If item.ToModify Then
                                    @<div style="margin-top:10px;"> @Html.ActionLink("Éditer", "Edit", New With {.id = item.Id})</div>
                                ElseIf item.ToControlContact Then
                                    @<div style="margin-top:10px;"> @Html.ActionLink("Contrôler", "Edit", New With {.id = item.Id})</div>
                                ElseIf item.ToControlDPD OrElse item.IsValid Then
                                    @<div style="margin-top:10px;"> @Html.ActionLink("Voir", "Details", New With {.id = item.Id})</div>
                                End If
                            ElseIf currentUsr.Role.Libelle.ToLower.Equals("dpd") Then
                                @If item.ToModify Then
                                If item.Service.Libelle.Equals(currentUsr.Service.Libelle) Then
                                    @<div style="margin-top:10px;"> @Html.ActionLink("Éditer", "Edit", New With {.id = item.Id})</div>
                                Else
                                    @<div style="margin-top:10px;"> @Html.ActionLink("Voir", "Details", New With {.id = item.Id})</div>
                                End If

                                ElseIf item.ToControlDPD Then
                                    @<div style="margin-top:10px;"> @Html.ActionLink("Contrôler", "Details", New With {.id = item.Id})</div>
                                ElseIf item.ToControlContact OrElse item.IsValid Then
                                    @<div style="margin-top:10px;"> @Html.ActionLink("Voir", "Details", New With {.id = item.Id})</div>
                                End If
                            End If
                        </td>
                    </tr>
                End If
            Next
        </table>
    </div>

    <div id="tabs-2">
        @code
            Dim lstIncident As List(Of Incident)
            If ViewBag.Incident IsNot Nothing Then
                lstIncident = CType(ViewBag.Incident, List(Of Incident))
            Else
                lstIncident = New List(Of Incident)
            End If

            @*@<div style="display:inline-block;">

                    @Html.DropDownList("triIncident", _
                               New SelectList(New List(Of String)(New String() {"Tout voir", _
                                                                                "Traitement à modifier", _
                                                                                "Traitement à contrôler", _
                                                                                "En attente DPO", _
                                                                                "Traitement valide"}), "Tout voir"), _
                               htmlAttributes:=New With {.class = "form-control", .onchange = ""})
                </div>*@
            If currentUsr.IdRole = 3 Then
            @<div style="display:inline-block;">
                @Html.DropDownList("TriServiceIncident", _
                           New SelectList(CType(ViewBag.Service, List(Of Service)), "Id", "Libelle"), _
                           htmlAttributes:=New With {.class = "form-control", .onchange = ""})
            </div>
            End If
            @<br />
        End Code

        <table id="lstIncident" class="table">
            <tr>
                <th>
                    @Html.DisplayName("Date de création")
                </th>
                <th>
                    @Html.DisplayName("Nom Incident")
                </th>
                <th>
                    @Html.DisplayName("Agent encodeur")
                </th>
                @If currentUsr.Role.Id = 3 Then
                    @<th>
                        @Html.DisplayName("Service")
                    </th>
                End If

                <th></th>
            </tr>

            @If lstIncident IsNot Nothing Then
                @For Each item In lstIncident
                    @<tr>
                        <td style="font-weight:bold;font-size:17px;">
                            <div>@Html.Raw(item.DateCreation.ToString("dd-MM-yyyy"))</div>
                        </td>

                        <td style="font-weight:bold;font-size:17px;">
                            <div>@Html.Raw(item.Nom)</div>
                        </td>

                        <td style="font-weight:bold;font-size:17px;">
                            <div>@Html.Raw(currentUsr.DisplayName)</div>
                        </td>

                        @If currentUsr.Role.Id = 3 Then
                            @<td style="font-weight:bold;font-size:17px;">
                                <div>@Html.Raw(currentUsr.Service.Libelle)</div>
                            </td>
                        End If

                        <td>
                            @If currentUsr.Role.Libelle.ToLower.Equals("agent") OrElse currentUsr.Role.Libelle.ToLower.Equals("contact") Then
                                @<div style="margin-top:10px;"> @Html.ActionLink("Voir", "Details","Incident", New With {.id = item.Id},nothing)  @*<a href="/tournai.rgpd/Incident/Details/@item.Id">Voir</a>*@</div>
                            Else
                                @<div style="margin-top:10px;"> @Html.ActionLink("Éditer", "Edit", "Incident", New With {.id = item.Id}, Nothing)  @*<a href="/Incident/Edit/@item.Id">Éditer</a>*@</div>
                            End If
                        </td>
                    </tr>
                Next
            End If
        </table>
    </div>

</div>
@*Lorsque je mets à jour des scripts je dois faire attention au fait que le layout ne va pas s'updater tout seul*@
<script src="~/Scripts/jquery-3.3.1.min.js"></script>
@*Jquery UI DOIT venir après Jquery et avant bootstrap*@
<script src="~/Scripts/jquery-ui-1.12.1.min.js"></script>
<script src="~/Scripts/bootstrap.min.js"></script>
<script>
    $(function () {
        
        $("#tabs").tabs({
          //  disabled: [1]
        });
    });
    $('#TriServiceIncident').change(function (e) {
        var idService = $("#TriServiceIncident").val();
        var data = new FormData();

        data.append('idService', idService);
        $.ajax({
            type: "POST",
            url: "/Incident/Index",
            contentType: false,
            processData: false,
            data: data,
            success: function (message) {
                var obj = JSON.parse(message);
                var i;

                if (obj != null) {
                    $('#lstIncident').html('');

                    @code
                        If currentUsr.Role.Id = 3 Then
                    End Code
                    $('#lstIncident').append('<tbody id="test"><tr><th><div>Date de création</div></th><th><div>Nom Incident</div></th><th><div>Agent encodeur</div></th><th><div>Service</div></th><th></th></tr></tbody>');
                    @code
                        End If
                    End Code

                    for (i = 0; i < obj.length; i++) {
                        $('#test').append('<tr><td style="font-weight:bold;font-size:17px;">' + obj[i].DateCrea + '</td><td style="font-weight:bold;font-size:17px;">' + obj[i].NomIncident + '</td><td style="font-weight:bold;font-size:17px;">' + obj[i].AgentEncodeur + '</td><td style="font-weight:bold;font-size:17px;">' + obj[i].Service + '</td><td><div style="margin-top:10px;"><a href="/Incident/Edit/' + obj[i].Id + '">Éditer</a></div></td></tr>');
                    }
                }
            },
            error: function (errorMsg) {
                alert(errorMsg);
            }
        });
    });
</script>