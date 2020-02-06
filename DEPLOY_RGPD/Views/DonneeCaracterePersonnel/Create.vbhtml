@ModelType RGPD_MVC.DonneeCaracterePersonnel
@Code
    ViewData("Title") = "Données à caractère personnel"
End Code

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Données à caractère personnel : Ajout d'un nouvel élément.</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Libelle, htmlAttributes:=New With {.class = "control-label col-md-2", .style = "font-weight: bold;"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Libelle, New With {.htmlAttributes = New With {.class = "form-control", .autocomplete = "off"}})
                @If ViewBag.Ispresent IsNot Nothing Then
                    @Html.ValidationMessageFor(Function(model) model.Libelle, ViewBag.IsPresent.ToString(), New With {.class = "text-danger"})
                Else
                    @Html.ValidationMessageFor(Function(model) model.Libelle, "", New With {.class = "text-danger"})
                End If
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Tooltip, htmlAttributes:=New With {.class = "control-label col-md-4", .style = "font-weight: bold;"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Tooltip, New With {.htmlAttributes = New With {.class = "form-control", .autocomplete = "off"}})
                @Html.ValidationMessageFor(Function(model) model.Tooltip, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" id="Enregistrer" value="Enregistrer" class="btn btnMenu" />
            </div>
        </div>
    </div>
End Using

<script src="~/Scripts/jquery-3.3.1.min.js"></script>
@*Jquery UI DOIT venir après Jquery et avant bootstrap*@
<script src="~/Scripts/jquery-ui-1.12.1.min.js"></script>
<script>
    @code
        If Session("Ajout") IsNot Nothing AndAlso CBool(Session("Ajout")) Then
            Session("Ajout") = false
    End Code
    alert("Nouvelle donnée à caractère personnel correctement ajoutée.");
    @code
    End If
    End Code
</script>
