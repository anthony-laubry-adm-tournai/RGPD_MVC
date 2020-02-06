@ModelType RGPD_MVC.Traitement
@Code
    ViewData("Title") = "Traitement"
End Code

@Using (Html.BeginForm("Create", "Traitement", FormMethod.Post, New With {.enctype = "multipart/form-data"}))
    @Html.AntiForgeryToken()

    @<div class="menu-2">
        @Html.EditorFor(Function(model) model.Nom, New With {.htmlAttributes = New With {.class = "nomTrt", .autocomplete = "off"}})
        <hr class="hrMnu" />
        <div class="MnuContexte">CONTEXTE</div>
        <hr class="hrMnu" />

        @Html.ActionLink("- Principe fondamentaux", "Edit", "Traitement", htmlAttributes:=New With {.class = "mnuCreaPrcpFond-current", .onclick = "return false;"})

        <div class="mnuRisque">RISQUES</div>
        <hr class="hrMnu" />

        <input type="submit" name="MsrPrevue" value="- Mesure existante ou prévue" class="linkButton mnuCreaRisque" />
        <input type="submit" id="AccIll" name="AccIll" value="- Accès illégitime à des données" class="linkButton mnuCreaRisque" />
        <input type="submit" id="ModNonDesire" name="ModNonDesi" value="- Modifications non désirées de données" class="linkButton mnuCreaRisque" />
        <input type="submit" id="DispDonn" name="DispDonn" value="- Disparition de données" class="linkButton mnuCreaRisque" onclick="return false;" />

        <hr class="hrMnu" />

        @Html.ActionLink("Annuler", "Index", "Traitement", htmlAttributes:=New With {.class = "btn btnMenu "})
        <input type="submit" name="Suivant" value="Suivant" class="btn btnMenu" />
         <input type="submit" name="Sauvegarder" value="Sauvegarder" class="btn btnMenu" />
        <hr class="hrMnu" />

        @Html.Label("Pièce jointe", htmlAttributes:=New With {.style = "color:#3EE095;font-weight:bold;"})
        <input type="file" name="file" accept="application/pdf" />
        <input type="submit" name="uploadFile" value="Uploader le fichier" class="btn btnMenu" onclick="TestFileType(this.form.file.value, ['pdf']);" />
        @If Session("uploadSuccess") IsNot Nothing Then
            @Html.Label(Session("uploadSuccess").ToString, htmlAttributes:=New With {.style = "color:#3EE095;font-weight:bold;"})
            Session("uploadSuccess") = String.Empty
        End If

        <hr class="hrMnu" />
        <div>
            @If Model.Fichier IsNot Nothing Then
                    For Each item As Fichier In Model.Fichier
                @<div>
                    @If item.Nom.Length > 26 Then
                            Dim nom As String = item.Nom
                            nom = nom.Substring(0, 15) & "..." & nom.Substring(nom.Length - 8, 4) & nom.Substring(nom.LastIndexOf("."))
                        @Html.ActionLink(nom, "OpenPDF", "Traitement", New With {.file = item.Path}, htmlAttributes:=New With {.name = "openPDF", .target = "_blank"})
                    Else
                        @Html.ActionLink(item.Nom, "OpenPDF", "Traitement", New With {.file = item.Path}, htmlAttributes:=New With {.name = "openPDF", .target = "_blank"})
                    End If
                    @*<br />*@
                    @Html.ActionLink("Supprimer", "DeleteDoc", "Traitement", New With {.id = item.Id, .idTrt = Model.Id}, htmlAttributes:=New With {.class = "boutonSup"})
                </div>
                @<br />
            Next
        End If
        </div>
    </div>

    @<div class="form-horizontal">
        <div class="TitreIntituleCreaTrt">
            <span style="color: #3EE095; font-weight: bold;">Principes fondamentaux</span><br />
            <p>Cette section vous permet de bâtir le dispositif de conformité aux principes de protection de la vie privée.</p>
        </div>
        <div class="trtPrcpFond">


            <div class="row">
                <span class="col-md-2"></span>
                <div id="donneePersonnel" class="col-md-4">
                    @Html.Label("Donnée à caractère personnel", htmlAttributes:=New With {.class = "control-label titreCategorie"})
                </div>
                <span class="col-md-2"></span>
                <div id="donneeSensible" class="col-md-4">
                    @Html.Label("Donnée à caractère sensible", htmlAttributes:=New With {.class = "control-label titreCategorie"})
                </div>
            </div>

            <div class="row">
                <div class="col-md-4">
                    @code
                        Dim lstDonneePers As List(Of DonneeCaracterePersonnel) = CType(ViewBag.donneePers, List(Of DonneeCaracterePersonnel))
                        For i As Integer = 0 To lstDonneePers.Count - 1 Step 2
                    @<div class="checkbox">
                        <input type="checkbox" name="DonneePers" value="@lstDonneePers(i).Id" /> <span class="chkDonnee control-label">@lstDonneePers(i).Libelle</span>
                        @If Not String.IsNullOrEmpty(lstDonneePers(i).Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@lstDonneePers(i).Tooltip">
                        End If
                    </div>
                    Next
                    End Code
                </div>

                <div class="col-md-3">
                    @code
                        lstDonneePers = CType(ViewBag.donneePers, List(Of DonneeCaracterePersonnel))
                        For i As Integer = 1 To lstDonneePers.Count - 1 Step 2
                    @<div class="checkbox">
                        <input type="checkbox" name="DonneePers" value="@lstDonneePers(i).Id" /> <span class="chkDonnee control-label">@lstDonneePers(i).Libelle</span>
                        @If Not String.IsNullOrEmpty(lstDonneePers(i).Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@lstDonneePers(i).Tooltip">
                        End If
                    </div>
                    Next
                    End Code
                </div>

                <div class="col-md-1">
                </div>

                <div class="col-md-4">
                    @code
                        Dim lstDonneeSens As List(Of DonneeCaractereSensible) = CType(ViewBag.donneeSens, List(Of DonneeCaractereSensible))
                        For Each elem As DonneeCaractereSensible In lstDonneeSens
                    @<div class="checkbox">
                        <input type="checkbox" name="DonneeSens" value="@elem.Id" /> <span class="chkDonnee control-label">@elem.Libelle</span>
                        @If Not String.IsNullOrEmpty(elem.Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@elem.Tooltip">
                        End If
                    </div>
                    Next
                    End Code
                </div>
                @*<div class="col-md-3">
                        @code
                            Dim lstDonneeSens As List(Of DonneeCaractereSensible) = CType(ViewBag.donneeSens, List(Of DonneeCaractereSensible))
                            For i As Integer = 0 To lstDonneeSens.Count - 1 Step 2
                            @<div class="checkbox">
                                <input type="checkbox" name="DonneePers" value="@lstDonneeSens(i).Id" /> <span class="chkDonnee control-label">@lstDonneeSens(i).Libelle</span>
                                @If Not String.IsNullOrEmpty(lstDonneeSens(i).Tooltip) Then
                                    @<img src="~/Img/interro.ico" class="curs" alt="" title="@lstDonneeSens(i).Tooltip">
                                End If
                            </div>
                        Next
                        End Code
                    </div>
                    <div class="col-md-3">
                        @code
                            lstDonneeSens = CType(ViewBag.donneeSens, List(Of DonneeCaractereSensible))
                            For i As Integer = 1 To lstDonneeSens.Count - 1 Step 2
                            @<div class="checkbox">
                                <input type="checkbox" name="DonneePers" value="@lstDonneeSens(i).Id" /> <span class="chkDonnee control-label">@lstDonneeSens(i).Libelle</span>
                                @If Not String.IsNullOrEmpty(lstDonneeSens(i).Tooltip) Then
                                    @<img src="~/Img/interro.ico" class="curs" alt="" title="@lstDonneeSens(i).Tooltip">
                                End If
                            </div>
                        Next
                        End Code
                    </div>*@
            </div>

            <br />

            <div class="row">
                <span class="col-md-1"></span>
                <div id="supportDonnee=" col-md-5">
                    @Html.Label("Support des données", htmlAttributes:=New With {.class = "control-label titreCategorie"})
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    @code
                        Dim lstSuppDonnee As List(Of SupportDonnee) = CType(ViewBag.supportDonnee, List(Of SupportDonnee))
                        For Each elem As SupportDonnee In lstSuppDonnee
                    @<div class="checkbox">
                        <input type="checkbox" name="SupportDonnee" value="@elem.Id" /> <span class="chkDonnee control-label">@elem.Libelle</span>
                        @If Not String.IsNullOrEmpty(elem.Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@elem.Tooltip">
                        End If
                    </div>
                    Next
                    End Code
                </div>
            </div>

            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Personne concernée", htmlAttributes:=New With {.class = "control-label col-md-5 bold", .style = "padding-top:5px;"})

                <div class="col-md-2">
                    @Html.DropDownListFor(Function(model) model.PersonneConcernee, _
                    New SelectList(CType(ViewBag.personneConcernee, List(Of PersonneConcernee)), "Id", "Libelle"), _
                    htmlAttributes:=New With {.class = "form-control"})

                    @Html.ValidationMessageFor(Function(model) model.IdPersonneConcerne, "", New With {.class = "text-danger"})
                </div>
            </div>

            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Durée de conservation des données", htmlAttributes:=New With {.class = "control-label col-md-5 bold", .style = "padding-top:5px;"})
                <div class="col-md-2">
                    @Html.DropDownListFor(Function(model) model.DureeConservationDonnee, _
                                      New SelectList(CType(ViewBag.conservationDonnee, List(Of DureeConservationDonnee)), "Id", "Libelle"), _
                                      htmlAttributes:=New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.IdDureeConservationDonnee, "", New With {.class = "text-danger"})
                </div>
            </div>

            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Légitimation à caractère personnel", htmlAttributes:=New With {.class = "control-label col-md-5 bold", .style = "pading-top:5px;"})
                <div class="col-md-3">
                    @Html.DropDownListFor(Function(model) model.LegitimationCaracterePersonnel, _
                                      New SelectList(CType(ViewBag.legitimationPersonnel, List(Of LegitimationCaracterePersonnel)), "Id", "Libelle"), _
                                      htmlAttributes:=New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.IdLegitimationPersonnel, "", New With {.class = "text-danger"})
                </div>
            </div>

            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Légitimation à caractère sensible", htmlAttributes:=New With {.class = "control-label col-md-5 bold", .style = "padding-top:5px;"})
                <div class="col-md-3">
                    @Html.DropDownListFor(Function(model) model.LegitimationCaractereSensible, _
                                  New SelectList(CType(ViewBag.legitimationSensible, List(Of LegitimationCaractereSensible)), "Id", "Libelle"), _
                                  htmlAttributes:=New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.IdLegitimationSensible, "", New With {.class = "text-danger"})
                </div>
            </div>

            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Finalité des données", htmlAttributes:=New With {.class = "control-label col-md-5 bold", .style = "padding-top:5px;"})
                <div class="col-md-3">
                    @Html.DropDownListFor(Function(model) model.FinaliteDonnee, _
                                  New SelectList(CType(ViewBag.finaliteDonnee, List(Of FinaliteDonnee)), "Id", "Libelle"), _
                                  htmlAttributes:=New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.IdFinaliteDonnee, "", New With {.class = "text-danger"})
                </div>
            </div>

            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Les données sont-elles exactes et tenues à jour ?", htmlAttributes:=New With {.class = "control-label col-md-5 bold"})
                <div class="col-md-3">
                    <span class="choixradio">
                        @Html.RadioButtonFor(Function(model) model.DonneeAJour, True, htmlAttributes:=New With {.class = "form-control resize choixradio"})
                        @Html.Label("Oui", htmlAttributes:=New With {.class = "chkDonnee"})
                    </span>
                    <span>&nbsp;&nbsp;</span>
                    <span class="choixradio">
                        @Html.RadioButtonFor(Function(model) model.DonneeAJour, False, htmlAttributes:=New With {.class = "form-control resize", .checked = "true"})
                        @Html.Label("Non", htmlAttributes:=New With {.class = "chkDonnee"})
                    </span>
                </div>
            </div>

            <br />

            <div class="row">
                @Html.LabelFor(Function(model) model.PrincipeProportionnalite, htmlAttributes:=New With {.class = "control-label col-md-8 bold"})
            </div>
            <div class="row">
                <div class="col-md-12">
                    @Html.EditorFor(Function(model) model.PrincipeProportionnalite, New With {.htmlAttributes = New With {.class = "form-control", .style = "min-width:1050px;min-height:200px;border-color:grey;", .autocomplete = "off"}})
                    @Html.ValidationMessageFor(Function(model) model.PrincipeProportionnalite, "", New With {.class = "text-danger"})
                </div>
            </div>

            <br />

            <div class="row">
                @Html.LabelFor(Function(model) model.GestionSousTraitance, htmlAttributes:=New With {.class = "control-label col-md-10 bold"})
            </div>
            <div class="row">
                <div class="col-md-12">
                    @Html.EditorFor(Function(model) model.GestionSousTraitance, New With {.htmlAttributes = New With {.class = "form-control", .style = "min-width:1050px;min-height:200px;border-color:grey;", .autocomplete = "off"}})
                    @Html.ValidationMessageFor(Function(model) model.GestionSousTraitance, "", New With {.class = "text-danger"})
                </div>
            </div>

            <br />

            <div class="row">
                @Html.LabelFor(Function(model) model.RemContact, htmlAttributes:=New With {.class = "control-label col-md-6 bold"})
                @Html.LabelFor(Function(model) model.RemDPD, htmlAttributes:=New With {.class = "control-label col-md-6 bold"})
            </div>
            <div class="row">
                <div class="col-md-6">
                    @Select Case CType(Session("Utilisateur"), Utilisateur).IdRole
                            Case 1
                        @Html.EditorFor(Function(model) model.RemContact, _
                                    New With {.htmlAttributes = New With {.class = "form-control", _
                                                                          .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;", _
                                                                          .readonly = "true", .autocomplete = "off"}})
                    Case 2
                        @Html.EditorFor(Function(model) model.RemContact, _
                                    New With {.htmlAttributes = New With {.class = "form-control", _
                                                                          .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;", _
                                                                          .autocomplete = "off"}})
                    Case 3
                        @Html.EditorFor(Function(model) model.RemContact, _
                                    New With {.htmlAttributes = New With {.class = "form-control", _
                                                                          .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;", _
                                                                          .readonly = "true", .autocomplete = "off"}})
                End Select
                    @Html.ValidationMessageFor(Function(model) model.RemContact, "", New With {.class = "text-danger"})
                </div>

                <div class="col-md-6">
                    @Select Case CType(Session("Utilisateur"), Utilisateur).IdRole
                            Case 1
                        @Html.EditorFor(Function(model) model.RemDPD, _
                                    New With {.htmlAttributes = New With {.class = "form-control", _
                                                                          .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;", _
                                                                          .readonly = "true", .autocomplete = "off"}})
                    Case 2
                        @Html.EditorFor(Function(model) model.RemDPD, _
                                    New With {.htmlAttributes = New With {.class = "form-control", _
                                                                          .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;", _
                                                                          .readonly = "true", .autocomplete = "off"}})
                    Case 3
                        @Html.EditorFor(Function(model) model.RemDPD, _
                                    New With {.htmlAttributes = New With {.class = "form-control", _
                                                                          .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;", _
                                                                          .autocomplete = "off"}})
                End Select
                    @Html.ValidationMessageFor(Function(model) model.RemDPD, "", New With {.class = "text-danger"})
                </div>
            </div>
        </div>

        <div id="dialog-confirm" title="Opération non valide">
            <p><span class="ui-icon ui-icon-alert" style="float:left; margin:12px 12px 20px 0;"></span>Veuillez créer les mesures existantes ou prévues contre les risques en premier lieu.</p>
        </div>

        <script src="~/Scripts/jquery-3.3.1.min.js"></script>
        @*Jquery UI DOIT venir après Jquery et avant bootstrap*@
        <script src="~/Scripts/jquery-ui-1.12.1.min.js"></script>
        <script>

            $(function () {
                $("#dialog-confirm").hide();

                $("#AccIll").on("click", function () {
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
                });

                $("#ModNonDesire").on("click", function () {
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
                });
                $("#DispDonn").on("click", function () {
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
                });
            });
        </script>
    </div>
End Using

