@Code
    ViewData("Title") = "Gestion des rôles"
End Code

<h2>Gestion des rôles utilisateurs.</h2>

@Using (Html.BeginForm("AttribuerRole", "GestionRole", FormMethod.Post))

    @<div class="form-horizontal">
        <div class="col-md-3">
            @Html.Label("Liste des services", htmlAttributes:=New With {.style = "font-weight:bold;text-decoration:underline;"})
            @Html.DropDownList("Service", _
                               New SelectList(CType(ViewBag.Service, List(Of Service)), "Id", "Libelle"), _
                               htmlAttributes:=New With {.class = "form-control",.onchange = "this.form.submit();"})
                        </div>

                        <br />

                        <div class="col-md-3">
                            @Html.Label("Liste des agents par service", htmlAttributes:=New With {.style = "font-weight:bold;text-decoration:underline;"})
                            @Html.DropDownList("Usr", _
                           New SelectList(CType(ViewBag.Utilisateur, List(Of Utilisateur)), "Id", "DisplayName"), _
                           htmlAttributes:=New With {.class = "form-control", .onchange = "this.form.submit();"})
                        </div>

                        <br />

                        <div class="col-md-3">
                            @Html.Label("Rôle a affecté :", htmlAttributes:=New With {.style = "font-weight:bold;text-decoration:underline;"})
                            @Html.DropDownList("Role", _
                           New SelectList(CType(ViewBag.Role, List(Of Role)), "Id", "Libelle"), _
                           htmlAttributes:=New With {.class = "form-control"})
                        </div>

                        <br />

                        <div class="col-md-3">
                            <input type="submit" name="Attribuer" value="Attribuer" id="Attribuer" class="btn btnMenu" onclick="return false;" />
                        </div>

                        <div id="dialog-confirm" title="Attribution d'un rôle'">
                            <p><span class="ui-icon ui-icon-info" style="float:left; margin:12px 12px 20px 0;"></span><span>Confirmez-vous l'attribution du nouveau rôle ?</span></p>
                        </div>
                    </div>
End Using

<script src="~/Scripts/jquery-3.3.1.min.js"></script>
@*Jquery UI DOIT venir après Jquery et avant bootstrap*@
<script src="~/Scripts/jquery-ui-1.12.1.min.js"></script>
<script>
    $("document").ready(function () {
        //cache la div qui sert de boite de dialogue.
        $("#dialog-confirm").hide();

        $("#Attribuer").on("click", function () {
            $("#dialog-confirm").dialog({
                resizable: false,
                height: "auto",
                width: 400,
                modal: true,
                //Définition des boutons de la boite de dialogue.
                buttons: {
                    "Oui": function () {
                        //si on valide l'attribution du rôle, l'action 'AttribuerRole' du controlleur 'GestioRole' est appelée via une requête Ajax.
                        $.post("/GestionRole/AttribuerRole", {Service: $('#Service').val(), usr: $('#Usr').val(), Role: $('#Role').val(), Attribuer: 'Attribuer' }, function (x) {
                        });
                        $(this).dialog("close");
                    },
                    "Non": function () {
                        //si on clique sur non, la boite de dialogue se referme.
                        $(this).dialog("close");
                    }
                }
            });
        });

        //Selectionne un élément de la ddlist
        $('#Service').val('@CLng(ViewBag.CurrServ)');
        $('#Usr').val('@CLng(ViewBag.CurrUsr)');
        $('#Role').val('@CLng(ViewBag.CurrUsrRole)');
    });
</script>
