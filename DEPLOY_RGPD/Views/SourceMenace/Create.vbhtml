@ModelType RGPD_MVC.SourceMenace
@Code
    ViewData("Title") = "Source des menaces"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
         <h4>Sources des menaces : Ajout d'un nouvel élément.</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Libelle, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Libelle, New With {.htmlAttributes = New With {.class = "form-control", .autocomplete = "off"}})
                @If ViewBag.IsPresent IsNot Nothing Then
                        @Html.ValidationMessageFor(Function(model) model.Libelle, ViewBag.IsPresent.ToString(), New With {.class = "text-danger"})
Else
                        @Html.ValidationMessageFor(Function(model) model.Libelle, "", New With {.class = "text-danger"})
End If
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Tooltip, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Tooltip, New With {.htmlAttributes = New With {.class = "form-control", .autocomplete = "off"}})
                @Html.ValidationMessageFor(Function(model) model.Tooltip, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Ajouter" class="btn btn-default" />
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
            Session("Ajout") = False
    End Code
    alert("Nouvelle source de menace correctement ajoutée.");
    @code
    End If
    End Code
</script>