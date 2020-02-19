@ModelType list(of RGPD_MVC.LieuIncident)
@Code
    ViewData("Title") = "Edit"
End Code

<h4>Édition</h4>
<hr />

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @<table class="table">
        <tr>
            <th style="display:none;"></th>
            <th>@Html.DisplayName("Libellé")</th>
        </tr>
        @code
            Dim i As Integer = 0
        End Code
        @For Each item As LieuIncident In Model
            @<tr>
                <td style="display:none;">@Html.Hidden("Id", item.Id)</td>

                <td>@Html.EditorFor(Function(modelItem) item.Libelle, Nothing, "Libelle", New With {.htmlAttributes = New With {.class = "form-control", .style = "width:100%;min-width:600px;", .autocomplete = "off"}})</td>
                @*<td style="min-width:600px;">
                        @Html.EditorFor(Function(modelItem) modelItem(i).Tooltip, New With {.htmlAttributes = New With {.class = "form-control setWidth", .autocomplete = "off"}})
                    </td>*@
            </tr>
            @code
                i = i + 1
            End Code
        Next
    </table>

    @<div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Enregistrer" class="btn btnMenu" />
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Annuler", "Index", "Traitement", Nothing)
</div>