@ModelType RGPD_MVC.LieuIncident
@Code
    ViewData("Title") = "Create"
End Code

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Nouveau lieu d'incident</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Libelle, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Libelle, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Libelle, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Ajouter" class="btn btnMenu" />
            </div>
        </div>
    </div>
End Using

<div>
   @Html.ActionLink("Annuler", "Index", "Traitement", Nothing)
</div>