@ModelType IEnumerable(of RGPD_MVC.DonneeCaractereSensible)
@Code
    ViewData("Title") = "Données à caractère sensible"
End Code

<div>
    <h4>Données à caractère sensible : Suppression d'un élément.</h4>
    <hr />

    <table class="table">
        <tr>
            <th style="display:none;"></th>
            <th>@Html.DisplayName("Libellé")</th>
            <th>@Html.DisplayName("Description")</th>
            <th></th>
        </tr>
        @code
            Dim i As Integer = 0
        End Code
        @For Each item As DonneeCaractereSensible In Model
            @<tr>
                @Using (Html.BeginForm("Delete", "DonneeCaractereSensible", FormMethod.Post))
                    @<td style="display:none;">@Html.Hidden("Id", item.Id)</td>

                    @<td>@Html.EditorFor(Function(modelItem) item.Libelle, New With {.htmlAttributes = New With {.class = "form-control", .style = "margin-top:12px;width:100%;min-width:300px;", .readonly = "readonly"}})</td>
                    @<td style="min-width:600px;">
                        @Html.EditorFor(Function(modelItem) item.Tooltip, New With {.htmlAttributes = New With {.class = "form-control setWidth", .readonly = "readonly"}})
                    </td>
                    @<td>
                        @*@Html.ActionLink("Supprimer", "Delete", New With {.id = item.Id})*@
                        <input type="submit" class="form-control hand" style="margin-top:12px;" value="Supprimer" id="@item.Id" name="button_@item.id" />
                    </td>
                End Using
            </tr>
            @code
            i = i + 1
            End Code
        Next
    </table>
</div>

<script src="~/Scripts/jquery-3.3.1.min.js"></script>
@*Jquery UI DOIT venir après Jquery et avant bootstrap*@
<script src="~/Scripts/jquery-ui-1.12.1.min.js"></script>
<script>
    @code
        If Session("Supprime") IsNot Nothing AndAlso CBool(Session("Supprime")) Then
            Session("Supprime") = False
    End Code
    alert("Suppression effectuée.");
    @code
    End If
    End Code
</script>