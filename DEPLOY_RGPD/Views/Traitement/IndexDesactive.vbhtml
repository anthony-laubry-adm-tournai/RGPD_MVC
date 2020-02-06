@ModelType IEnumerable(Of RGPD_MVC.Traitement)
@Code
    ViewData("Title") = "Traitement désactivé"
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
        @*@If item.IsActif Then*@
            @<tr>
                <td>
                    @If item.IsValid Then
                        @<div class='isValid' title='Est valide'></div>
                    ElseIf item.ToModify Then
                        @<div class='modif' title='A modifier'></div>
                    ElseIf item.ToControlContact Then
                        @<div class='toBeControledContact' title='En attente de validation par le Contact RGPD du service'></div>
                    ElseIf item.ToControlDPD Then
                        @<div class='toBeControledDPD' title='En attente de validation par le/la DPO'></div>
                    End If
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Nom)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.AgentEncodeur)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.AgentContact)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.DateCrea)
                </td>
                <td>
                    @*@If item.IsActif Then*@
                        @Html.ActionLink("Activer", "Active", New With {.id = item.Id}, New With {.class = "active"})
                    @*End If*@
                </td>
                <td>
                    @Html.ActionLink("Voir", "Details", New With {.id = item.Id})
                    @*@If currentUsr.Role.Libelle.ToLower.Equals("agent") Then
                        @If item.ToModify Then
                            @Html.ActionLink("Éditer", "Edit", New With {.id = item.Id})
                        ElseIf item.ToControlContact OrElse item.ToControlDPD OrElse item.IsValid Then
                            @Html.ActionLink("Voir", "Details", New With {.id = item.Id})
                        End If
                    ElseIf currentUsr.Role.Libelle.ToLower.Equals("contact") Then
                        @If item.ToModify Then
                            @Html.ActionLink("Éditer", "Edit", New With {.id = item.Id})
                        ElseIf item.ToControlContact Then
                            @Html.ActionLink("Contrôler", "Details", New With {.id = item.Id})
                        ElseIf item.ToControlDPD OrElse item.IsValid Then
                            @Html.ActionLink("Voir", "Details", New With {.id = item.Id})
                        End If
                    ElseIf currentUsr.Role.Libelle.ToLower.Equals("dpd") Then
                        @If item.ToModify Then
                        If item.Service.Libelle.Equals(currentUsr.Service.Libelle) Then
                        @Html.ActionLink("Éditer", "Edit", New With {.id = item.Id})
                        Else
                        @Html.ActionLink("Voir", "Details", New With {.id = item.Id})
                        End If

                        ElseIf item.ToControlDPD Then
                        @Html.ActionLink("Contrôler", "Details", New With {.id = item.Id})
                        ElseIf item.ToControlContact OrElse item.IsValid Then
                        @Html.ActionLink("Voir", "Details", New With {.id = item.Id})
                        End If
                    End If*@
                </td>
            </tr>
        'End If
    Next

</table>