@ModelType IEnumerable(Of RGPD_MVC.Traitement)
@Code
    ViewData("Title") = "Liste des traitements"
    Dim currentUsr As Utilisateur = CType(Session("Utilisateur"), Utilisateur)
End Code

@code
    Select Case currentUsr.Role.Id

        Case 1, 2
            'agent et contact

        Case 3
            'DPD

    End Select
End Code

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
        <th>
            @Html.DisplayNameFor(Function(model) model.DateCrea)
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