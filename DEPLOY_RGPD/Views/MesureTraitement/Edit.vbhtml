@ModelType List(Of RGPD_MVC.MesureTraitement)
@Code
    ViewData("Title") = "Mesure contre les risques"
    Dim nbMesure As Integer = 0
End Code

@Using (Html.BeginForm("Edit", "MesureTraitement", FormMethod.Post, New With {.enctype = "multipart/form-data"}))
    @Html.AntiForgeryToken()

    @<div class="menu-2">
        <input type="text" value="@Session("TrtNom").ToString" name="NomTrt" class="nomTrt text-box single-line" />
        <hr class="hrMnu" />
        <div class="MnuContexte">CONTEXTE</div>
        <hr class="hrMnu" />

         <input type="submit" name="PrcpFond" value="- principe fondamentaux" class="linkButton mnuCreaPrcpFond" />

        <div class="mnuRisque">RISQUES</div>
        <hr class="hrMnu" />

        <input type="submit" name="MsrPrevue" value="- Mesure existante ou prévue" class="linkButton mnuCreaRisque-current" />
        <input type="submit" name="AccIll" value="- Accès illégitime à des données" class="linkButton mnuCreaRisque" />
        <input type="submit" name="ModNonDesi" value="- Modifications non désirées de données" class="linkButton mnuCreaRisque" />
        <input type="submit" name="DispDonn" value="- Disparition de données" class="linkButton mnuCreaRisque" />

        <hr class="hrMnu" />

        @Html.ActionLink("Annuler", "Index", "Traitement", "", htmlAttributes:=New With {.class = "btn btnMenu "})
         <input type="submit" name="Precedent" value="Précédent" class="btn btnMenu" />
        <input type="submit" name="Suivant" value="Suivant" class="btn btnMenu" />
         <input type="submit" name="Sauvegarder" value="Sauvegarder" class="btn btnMenu" />
         <hr class="hrMnu" />

         @Html.Label("Pièce jointe", htmlAttributes:=New With {.style = "color:#3EE095;font-weight:bold;"})
         <input type="file" name="file" accept="image/jpeg" />
         <input type="submit" name="uploadFile" value="Uploader le fichier" class="btn btnMenu" />
         @If Session("uploadSuccess") IsNot Nothing Then
             @Html.Label(Session("uploadSuccess").ToString, htmlAttributes:=New With {.style = "color:#3EE095;font-weight:bold;"})
             Session("uploadSuccess") = String.Empty
         End If

         <hr class="hrMnu" />
         <div>
             @If ViewBag.ListeFichier IsNot Nothing Then
                     Dim lst As List(Of Fichier) = CType(ViewBag.ListeFichier,List(Of Fichier))
                     For Each item As Fichier In lst
                 @<div>
                     @If item.Nom.Length > 26 Then
                             Dim nom As String = item.Nom
                             nom = nom.Substring(0, 15) & "..." & nom.Substring(nom.Length - 8, 4) & nom.Substring(nom.LastIndexOf("."))
                         @Html.ActionLink(nom, "OpenPDF", "MesureTraitement", New With {.file = item.Path}, htmlAttributes:=New With {.name = "openPDF", .target = "_blank"})
                     Else
                         @Html.ActionLink(item.Nom, "OpenPDF", "MesureTraitement", New With {.file = item.Path}, htmlAttributes:=New With {.name = "openPDF", .target = "_blank"})
                     End If
                     @*<br />*@
                     @Html.ActionLink("Supprimer", "DeleteDoc", "MesureTraitement", New With {.id = item.Id, .idTrt = item.IdTraitement}, htmlAttributes:=New With {.class = "boutonSup"})
                 </div>
                 @<br />
             Next
         End If
         </div>
    </div>

    @<div class="form-horizontal" style="height:100%;">
        <div class="TitreIntituleCreaTrt" style="border: 1px solid grey; text-align: center; margin-top: 1%; margin-bottom: 10px; padding-top: 10px; padding-bottom: 10px;">
            <span style="color: #FD4664; font-weight: bold;">Risques</span><br />
            <span style="font-size:11px;">
                Cette section vous permet d'apprécier les risques sur la vie privée, <br />
                compte tenu des mesures existantes ou prévues.
            </span><br />
            <span style="color: #FD4664; ">Mesure existante ou prévue</span><br />
            <span style="font-size:11px;">
                Cette partie vous permet de recenser les mesures <br />
                (existantes ou prévues) contribuant à la sécurité des données.
            </span>
        </div>
        <div style="text-align: center; margin-bottom: 1%;">
            <input class="MainBouton" type="button" value="+ Créer une mesure (ou en ajouter une proposée dans la base de connaissance)" onclick="AddNewInput()" />
        </div>
    @If ViewBag.Alert IsNot Nothing AndAlso Not String.IsNullOrEmpty(ViewBag.Alert.ToString) Then
            @<label style="color:red;font-size:15px;">@Viewbag.Alert.tostring()</label>@<br />
        End If

        <div class="trtMsr">
            <div id="divCont">
                @For Each elem As MesureTraitement In Model
                    @<div id="existMsr_@elem.Id" class="trtMsr newMsr" style="border: 1px solid black;position:relative;margin-left:-7%;max-width:1050px;width:100%;padding:1%;">
                        <div class="form-group">
                            <input type="hidden" id="oldId" name="oldId" value="@elem.id" />
                            <input name="oldTitreMsr" style="display:inline-block;" autocomplete="off" class="form-control col-md-4" value="@elem.Titre" />
                            <a href="#" class="linkSupMsr" onclick="RemoveExist(existMsr_@elem.Id);" title="Supprimer cette mesure">Supprimer</a><br /><br />
                            <label style="color:#20CA79;">Description</label><br />
                            <textarea name="oldDescrMesure" id="descrexistMsr_@elem.id" class="form-control col-md-8" style="min-height:200px;height:100%;min-width:1025px;width:100%;">@elem.Explication</textarea><br />
                            <label class="commenter" onclick="ShowHideCom(comexistMsr_@elem.id)">Commenter ▼</label><br />
                            <textarea name="oldCommMsr" id="comexistMsr_@elem.id" class="form-control col-md-8 commentaire" style="min-width: 1025px;width:100%;">@elem.Commentaire</textarea>
                        </div>
                    </div>
                    @<br />
                Next
            </div>
        </div>
    </div>

    @*Modification à la demande d'anaïs => cacher les mesures prédéfinies*@
    @<div id="MesureExistante" style="display:none;">
    @code
        Dim listeMesure As List(Of Mesure) = CType(ViewBag.Mesure, List(Of Mesure))

        For Each item As Mesure In listeMesure
            nbMesure += 1
        @<div style="margin-top:1.5%;">
            <span style="color:red;">@item.Type</span> &nbsp;

            @If item.Type.ToLower.StartsWith("mesure") Then
                @<div style="display:inline-block;float:right;">
                    <a href="#" class="linkAjMsr" onclick="AddTextBox(@nbMesure);" title="Ajouter cette mesure">Ajouter</a>
                </div>
            End If

            <br />
            <label id="titre_@nbMesure" class="titreMsr" onclick="ShowHide(@nbMesure)" style="font-weight:500;">&or; @item.Titre</label>
            <hr />
            <div id="description_@nbMesure" class="description">
                <label id="descr_@nbMesure">@item.Description</label>
            </div>
        </div>
    Next
    End Code
</div>
End Using
<script src="~/Scripts/jquery-3.3.1.min.js"></script>
@*Jquery UI DOIT venir après Jquery et avant bootstrap*@
<script src="~/Scripts/jquery-ui-1.12.1.min.js"></script>
<script>
   
    $(function () {
        $("#dialog-confirm").hide();

        $("#AccIll").on("click", function () {
            var content = document.getElementsByName("titreMsr")
            if (content.length < 1) {
                $("#dialog-confirm").dialog({
                    resizable: false,
                    height: "auto",
                    width: 400,
                    modal: true,
                    buttons: {
                        "Ok": function () {
                            $(this).dialog("close");
                        }
                    }
                })
                return false;
            }
        });

        $("#ModNonDesire").on("click", function () {
            var content = document.getElementsByName("titreMsr")
            if (content.length < 1) {
                $("#dialog-confirm").dialog({
                    resizable: false,
                    height: "auto",
                    width: 400,
                    modal: true,
                    buttons: {
                        "Ok": function () {
                            $(this).dialog("close");
                        }
                    }
                })
                return false;
            }
        });

        $("#DispDonn").on("click", function () {
            var content = document.getElementsByName("titreMsr")
            if (content.length < 1) {
                $("#dialog-confirm").dialog({
                    resizable: false,
                    height: "auto",
                    width: 400,
                    modal: true,
                    buttons: {
                        "Ok": function () {
                            $(this).dialog("close");
                        }
                    }
                })
                return false;
            }
        });
    });
    
    $(".commentaire").hide();
    $(".description").hide();

    function ShowHide(id) {
        if ($("#comexistMsr_" + id).is(":visible")) {
            $("#comexistMsr_" + id).hide();
        }
        else {
            $("#comexistMsr_" + id).show();
        }
    }

    function ShowHide(id) {
        if ($("#description_" + id).is(":visible")) {
            $("#description_" + id).hide();
        }
        else {
            $("#description_" + id).show();
        }
    }

    function ShowHideCom(id) {
        if ($(id).is(":visible")) {
            $(id).hide();
        }
        else {
            $(id).show();
        }
    }

    function GetDynamicTextbox(value) {
        var arrow = "&or;"
        var titre = document.getElementById("titre_" + value).innerHTML.replace(arrow, "");
        var descr = document.getElementById("descr_" + value).innerText;

        return '<div id="msrAj_' + value + '" class="trtMsr" style="border: 1px solid black;position:relative;margin-left:-7%;max-width:1050px;width:100%;padding:1%;"><div class="form-group"><input name="titreMsr" autocomplete="off" style="display:inline-block;" class = "form-control col-md-4" value="' + titre + '"></input> <a href="#" class="linkSupMsr" onclick="RemoveTextBox(msrAj_' + value + ');" title="Supprimer cette mesure">Supprimer</a><br/><br/><label style="color:#20CA79;">Description</label><br/><textarea name="descrMesure" id="descrMsr_' + value + '" class = "form-control col-md-8" style="min-width:1025px;min-height:200px;height:100%;">' + descr + '</textarea><br/><label class="commenter" onclick="ShowHideCom(commentaire_' + value + ')">Commenter ▼</label><br/><textarea name="commMsr" id="commentaire_' + value + '" class = "form-control col-md-8 commentaire" style="min-width:1025px;"></textarea></div></div><br/>'
    }

    function AddNewInput() {
        var div = document.createElement('DIV');
        var nbNewMsr = (document.getElementsByClassName("newMsr").length + 1)
        div.innerHTML = '<div id="newMsr_' + nbNewMsr + '" class="trtMsr newMsr" style="border: 1px solid black;position:relative;margin-left:-7%;max-width:1050px;width:100%;padding:1%;"><div class="form-group"><input name="titreMsr" autocomplete="off" style="display:inline-block;" class = "form-control col-md-4"></input> <a href="#" class="linkSupMsr" onclick="RemoveNewInput(newMsr_' + nbNewMsr + ');" title="Supprimer cette mesure">Supprimer</a><br/><br/><label style="color:#20CA79;">Description</label><br/><textarea name="descrMesure" id="descrNewMsr_' + nbNewMsr + '" class = "form-control col-md-8" style="min-width:1025px;min-height:200px;height:100%;"></textarea><br/><label class="commenter" onclick="ShowHideCom(newMsrCom_' + nbNewMsr + ')">Commenter ▼</label><br/><textarea name="commMsr" id="newMsrCom_' + nbNewMsr + '" class = "form-control col-md-8 commentaire" style="min-width:1025px;"></textarea></div></div><br/>'
        document.getElementById("divCont").insertBefore(div, document.getElementById("divCont").children[0]);
        $(".commentaire").hide();
    }

    function AddTextBox(itemID) {
        var div = document.createElement('DIV');
        div.innerHTML = GetDynamicTextbox(itemID);
        document.getElementById("divCont").insertBefore(div, document.getElementById("divCont").children[0]); //.appendChild(div);
        $(".commentaire").hide();
    }

    function RemoveExist(divId)
    {        
        document.getElementById("divCont").removeChild(divId);
    }
    function RemoveNewInput(div) {
        document.getElementById("divCont").removeChild(div.parentNode);
    }
    function RemoveTextBox(div) {
        document.getElementById("divCont").removeChild(div.parentNode);
    }
</script>

