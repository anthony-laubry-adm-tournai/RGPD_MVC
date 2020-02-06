@ModelType IENumerable(of RGPD_MVC.LegitimationCaractereSensible)
@Code
    ViewData("Title") = "Base de légitimation à caractère sensible"
End Code
@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @<h4>Légitimation à caractère sensible : Modification d'un élément.</h4>

    @<table class="table">
        <tr>
            <th style="display:none;"></th>
            <th>@Html.DisplayName("Libellé")</th>
            <th>@Html.DisplayName("Description")</th>
        </tr>
        @code
            Dim i As Integer = 0
        End Code
        @For Each item As LegitimationCaractereSensible In Model
            @<tr>
                <td style="display:none;">@Html.Hidden("Id", item.Id)</td>

                <td>@Html.EditorFor(Function(modelItem) modelItem(i).Libelle, New With {.htmlAttributes = New With {.class = "form-control", .style = "width:100%;min-width:300px;", .autocomplete="off"}})</td>
                <td style="min-width:600px;">
                    @Html.EditorFor(Function(modelItem) modelItem(i).Tooltip, New With {.htmlAttributes = New With {.class = "form-control setWidth", .autocomplete = "off"}})
                </td>
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