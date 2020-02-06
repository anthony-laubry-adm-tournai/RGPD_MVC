@ModelType RGPD_MVC.Traitement
@Code
    ViewData("Title") = "Traitement"
    Dim currUsr As Utilisateur = CType(Session("Utilisateur"), Utilisateur)
End Code

@Using (Html.BeginForm("Test", "Traitement", FormMethod.Post))
    @Html.AntiForgeryToken()
    @<div class="menu-2">
        @Html.EditorFor(Function(model) model.Nom, New With {.htmlAttributes = New With {.class = "nomTrt", .readonly = "readonly"}})
        <hr class="hrMnu" />
        <div class="MnuContexte">CONTEXTE</div>
        <hr class="hrMnu" />

        <input type="submit" name="PrcpFond" value="- principe fondamentaux" class="linkButton mnuCreaPrcpFond" style="background-color:#3EE095;" />

        <div class="mnuRisque">RISQUES</div>
        <hr class="hrMnu" />

        <input type="submit" name="MsrPrevue" value="- Mesure existante ou prévue" class="linkButton mnuCreaRisque" />
        <input type="submit" name="AccIll" value="- Accès illégitime à des données" class="linkButton mnuCreaRisque" />
        <input type="submit" name="ModNonDesi" value="- Modifications non désirées de données" class="linkButton mnuCreaRisque" />
        <input type="submit" name="DispDonn" value="- Disparition de données" class="linkButton mnuCreaRisque" />

        <hr class="hrMnu" />

        <input type="submit" name="Suivant" value="Suivant" class="btn btnMenu" />

        <hr class="hrMnu" />

        @Select Case currUsr.Role.Id
                Case 1
            @<input type="submit" name="retourAcc" value="Retour accueil" class="btn btnMenu" />
            If Model.IsValid Then
            @<input type="submit" name="retourModif" value="Modifier" class="btn btnMenu" />
        End If
    Case 2
        If Model.IsValid Then
            @<input type="submit" name="retourModif" value="Modifier" class="btn btnMenu" />
        Else
            @<input type="submit" name="Amodif" value="À modifier" class="btn btnMenu" />
            @<input type="submit" name="Valide" value="Validation DPO" class="btn btnMenu" />
        End If
    Case 3
        If Model.IsValid Then
            @<input type="submit" name="retourModif" value="Modifier" class="btn btnMenu" />
        ElseIf Model.ToControlContact Then
            @<input type="submit" name="retourAcc" value="Retour accueil" class="btn btnMenu" />
        Else
            @<input type="submit" name="Amodif" value="À modifier" class="btn btnMenu" />
            @<input type="submit" name="Valide" value="Valide" class="btn btnMenu" />
        End If
End Select
        <hr class="hrMnu" />
         @Html.Label("Pièce jointe", htmlAttributes:=New With {.style = "color:#3EE095;font-weight:bold;"})
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
                </div>
                @<br />
            Next
        End If
        </div>

    </div>

    @<div>
        <div class="TitreIntituleCreaTrt">
            <span style="color: #3EE095; font-weight: bold;">Principes fondamentaux</span><br />
            <p>Cette section vous permet de bâtir le dispositif de conformité aux principes de protection de la vie privée.</p>
        </div>

        <div class="trtPrcpFond">

            @Html.Hidden("id", Model.Id)


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
                            If Model.DonneeCaracterePersonnel.Contains(lstDonneePers(i)) Then
                    @<div class="checkbox">
                        <input type="checkbox" name="DonneePers" value="@lstDonneePers(i).Id" checked="checked" disabled="disabled" /> <span class="chkDonnee control-label">@lstDonneePers(i).Libelle</span>
                        @If Not String.IsNullOrEmpty(lstDonneePers(i).Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@lstDonneePers(i).Tooltip">
                        End If
                    </div>
                    Else
                    @<div class="checkbox">
                        <input type="checkbox" name="DonneePers" value="@lstDonneePers(i).Id" disabled="disabled" /> <span class="chkDonnee control-label">@lstDonneePers(i).Libelle</span>
                        @If Not String.IsNullOrEmpty(lstDonneePers(i).Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@lstDonneePers(i).Tooltip">
                        End If
                    </div>
                    End If
                Next
                    End Code
                </div>

                <div class="col-md-3">
                    @code
                        lstDonneePers = CType(ViewBag.donneePers, List(Of DonneeCaracterePersonnel))
                        For i As Integer = 1 To lstDonneePers.Count - 1 Step 2
                            If Model.DonneeCaracterePersonnel.Contains(lstDonneePers(i)) Then
                    @<div class="checkbox">
                        <input type="checkbox" name="DonneePers" value="@lstDonneePers(i).Id" checked="checked" disabled="disabled" /> <span class="chkDonnee control-label">@lstDonneePers(i).Libelle</span>
                        @If Not String.IsNullOrEmpty(lstDonneePers(i).Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@lstDonneePers(i).Tooltip">
                        End If
                    </div>
                    Else
                    @<div class="checkbox">
                        <input type="checkbox" name="DonneePers" value="@lstDonneePers(i).Id" disabled="disabled" /> <span class="chkDonnee control-label">@lstDonneePers(i).Libelle</span>
                        @If Not String.IsNullOrEmpty(lstDonneePers(i).Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@lstDonneePers(i).Tooltip">
                        End If
                    </div>
                    End If
                Next
                    End Code
                </div>

                <div class="col-md-1">
                </div>

                <div class="col-md-4">
                    @code
                        Dim lstDonneeSens As List(Of DonneeCaractereSensible) = CType(ViewBag.donneeSens, List(Of DonneeCaractereSensible))
                        For i As Integer = 0 To lstDonneeSens.Count - 1
                            If Model.DonneeCaractereSensible.Contains(lstDonneeSens(i)) Then
                    @<div class="checkbox">
                        <input type="checkbox" name="DonneeSens" value="@lstDonneeSens(i).Id" checked="checked" disabled="disabled" /> <span class="chkDonnee control-label">@lstDonneeSens(i).Libelle</span>
                        @If Not String.IsNullOrEmpty(lstDonneeSens(i).Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@lstDonneeSens(i).Tooltip">
                        End If
                    </div>
                    Else
                    @<div class="checkbox">
                        <input type="checkbox" name="DonneeSens" value="@lstDonneeSens(i).Id" disabled="disabled" /> <span class="chkDonnee control-label">@lstDonneeSens(i).Libelle</span>
                        @If Not String.IsNullOrEmpty(lstDonneeSens(i).Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@lstDonneeSens(i).Tooltip">
                        End If
                    </div>
                    End If
                Next
                    End Code
                </div>
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
                            If Model.SupportDonnee.Contains(elem) Then
                    @<div class="checkbox">
                        <input type="checkbox" name="SupportDonnee" value="@elem.Id" checked="checked" disabled="disabled" /> <span class="chkDonnee control-label">@elem.Libelle</span>
                        @If Not String.IsNullOrEmpty(elem.Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@elem.Tooltip">
                        End If
                    </div>
                    Else
                    @<div class="checkbox">
                        <input type="checkbox" name="SupportDonnee" value="@elem.Id" disabled="disabled" /> <span class="chkDonnee control-label">@elem.Libelle</span>
                        @If Not String.IsNullOrEmpty(elem.Tooltip) Then
                            @<img src="~/Img/interro.ico" class="curs" alt="" title="@elem.Tooltip">
                        End If
                    </div>
                    End If
                Next
                    End Code
                </div>
            </div>

            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Personne concernée", htmlAttributes:=New With {.class = "control-label col-md-5 bold", .style = "padding-top:5px;"})

                <div class="col-md-2">
                    @Html.DropDownListFor(Function(model) model.IdPersonneConcerne, _
                New SelectList(CType(ViewBag.personneConcernee, List(Of PersonneConcernee)), "Id", "Libelle", Model.IdPersonneConcerne), _
                htmlAttributes:=New With {.class = "form-control", .name = "PersonneConcernee", .disabled = "disabled"})

                    @Html.ValidationMessageFor(Function(model) model.IdPersonneConcerne, "", New With {.class = "text-danger"})
                </div>
            </div>

            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Durée de conservation des données", htmlAttributes:=New With {.class = "control-label col-md-5 bold", .style = "padding-top:5px;"})
                <div class="col-md-2">
                    @Html.DropDownListFor(Function(model) model.IdDureeConservationDonnee, _
                New SelectList(CType(ViewBag.conservationDonnee, List(Of DureeConservationDonnee)), "Id", "Libelle", Model.IdDureeConservationDonnee), _
                htmlAttributes:=New With {.class = "form-control", .disabled = "disabled"})
                    @Html.ValidationMessageFor(Function(model) model.IdDureeConservationDonnee, "", New With {.class = "text-danger"})
                </div>
            </div>
            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Légitimation à caractère personnel", htmlAttributes:=New With {.class = "control-label col-md-5 bold", .style = "pading-top:5px;"})
                <div class="col-md-3">
                    @Html.DropDownListFor(Function(model) model.IdLegitimationPersonnel, _
                New SelectList(CType(ViewBag.legitimationPersonnel, List(Of LegitimationCaracterePersonnel)), "Id", "Libelle", Model.IdLegitimationPersonnel), _
                htmlAttributes:=New With {.class = "form-control", .disabled = "disabled"})
                    @Html.ValidationMessageFor(Function(model) model.IdLegitimationPersonnel, "", New With {.class = "text-danger"})
                </div>
            </div>
            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Légitimation à caractère sensible", htmlAttributes:=New With {.class = "control-label col-md-5 bold", .style = "padding-top:5px;"})
                <div class="col-md-3">
                    @Html.DropDownListFor(Function(model) model.IdLegitimationSensible, _
                New SelectList(CType(ViewBag.legitimationSensible, List(Of LegitimationCaractereSensible)), "Id", "Libelle", Model.IdLegitimationSensible), _
                htmlAttributes:=New With {.class = "form-control", .disabled = "disabled"})
                    @Html.ValidationMessageFor(Function(model) model.IdLegitimationSensible, "", New With {.class = "text-danger"})
                </div>
            </div>

            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Finalité des données", htmlAttributes:=New With {.class = "control-label col-md-5 bold", .style = "padding-top:5px;"})
                <div class="col-md-3">
                    @Html.DropDownListFor(Function(model) model.IdFinaliteDonnee, _
                New SelectList(CType(ViewBag.finaliteDonnee, List(Of FinaliteDonnee)), "Id", "Libelle", Model.IdFinaliteDonnee), _
                htmlAttributes:=New With {.class = "form-control", .disabled = "disabled"})
                    @Html.ValidationMessageFor(Function(model) model.IdFinaliteDonnee, "", New With {.class = "text-danger"})
                </div>
            </div>
            <br />

            <div class="row">
                <span class="col-md-2"></span>
                @Html.Label("Les données sont-elles exactes et tenues à jour ?", htmlAttributes:=New With {.class = "control-label col-md-5 bold"})
                <div class="col-md-3">
                    @If Model.DonneeAJour Then
                        @Html.RadioButtonFor(Function(model) model.DonneeAJour, True, htmlAttributes:=New With {.class = "form-control resize", .checked = "true", .disabled = "disabled"})
                        @Html.Label("Oui")
                        @<span>&nbsp;&nbsp;</span>
                        @Html.RadioButtonFor(Function(model) model.DonneeAJour, False, htmlAttributes:=New With {.class = "form-control resize", .disabled = "disabled"})
                        @Html.Label("Non")
                    Else
                        @Html.RadioButtonFor(Function(model) model.DonneeAJour, True, htmlAttributes:=New With {.class = "form-control resize", .disabled = "disabled"})
                        @Html.Label("Oui")
                        @<span>&nbsp;&nbsp;</span>
                        @Html.RadioButtonFor(Function(model) model.DonneeAJour, False, htmlAttributes:=New With {.class = "form-control resize", .checked = "true", .disabled = "disabled"})
                        @Html.Label("Non")
                    End If
                </div>
            </div>

            <br />

            <div class="row">
                @Html.LabelFor(Function(model) model.PrincipeProportionnalite, htmlAttributes:=New With {.class = "control-label col-md-8 bold"})
            </div>
            <div class="row">
                <div class="col-md-12">
                    @Html.EditorFor(Function(model) model.PrincipeProportionnalite, New With {.htmlAttributes = New With {.class = "form-control", .style = "min-width:1050px;min-height:200px;border-color:grey;", .readonly = "readonly"}})
                    @Html.ValidationMessageFor(Function(model) model.PrincipeProportionnalite, "", New With {.class = "text-danger"})
                </div>
            </div>

            <br />

            <div class="row">
                @Html.LabelFor(Function(model) model.GestionSousTraitance, htmlAttributes:=New With {.class = "control-label col-md-10 bold"})
            </div>
            <div class="row">
                <div class="col-md-12">
                    @Html.EditorFor(Function(model) model.GestionSousTraitance, New With {.htmlAttributes = New With {.class = "form-control", .style = "min-width:1050px;min-height:200px;border-color:grey;", .readonly = "readonly"}})
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
                .readonly = "true"}})
                    Case 2
                        @Html.EditorFor(Function(model) model.RemContact, _
                New With {.htmlAttributes = New With {.class = "form-control", _
                .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;"}})
                    Case 3
                        @Html.EditorFor(Function(model) model.RemContact, _
                New With {.htmlAttributes = New With {.class = "form-control", _
                .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;", _
                .readonly = "true"}})
                End Select
                    @Html.ValidationMessageFor(Function(model) model.RemContact, "", New With {.class = "text-danger"})
                </div>

                <div class="col-md-6">
                    @Select Case CType(Session("Utilisateur"), Utilisateur).IdRole
                            Case 1
                        @Html.EditorFor(Function(model) model.RemDPD, _
                New With {.htmlAttributes = New With {.class = "form-control", _
                .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;", _
                .readonly = "true"}})
                    Case 2
                        @Html.EditorFor(Function(model) model.RemDPD, _
                New With {.htmlAttributes = New With {.class = "form-control", _
                .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;", _
                .readonly = "true"}})
                    Case 3
                        @Html.EditorFor(Function(model) model.RemDPD, _
                New With {.htmlAttributes = New With {.class = "form-control", _
                .style = "min-width:482px;max-width:482px;min-height:200px;border-color:grey;"}})
                End Select
                    @Html.ValidationMessageFor(Function(model) model.RemDPD, "", New With {.class = "text-danger"})
                </div>
            </div>
        </div>
    </div>
    @<div id="divInfoTrt">
        @Html.Label("Date de création", htmlAttributes:=New With {.style = "display:inline-block;font-weight:bold;width:75%;", .class = "lbinfoTrt"})
        @Html.Label(Model.DateCrea.ToString(), htmlAttributes:=New With {.class = "infoTrt", .style = "width:75%;"})
        <br />
        @Html.Label("Date de modification", htmlAttributes:=New With {.style = "display:inline-block;font-weight:bold;width:75%;", .class = "lbinfoTrt"})
        @Html.Label(Model.DateModif.ToString, htmlAttributes:=New With {.class = "infoTrt", .style = "width:75%;"})
        <br />
        @Html.Label("Agent encodeur", htmlAttributes:=New With {.style = "display:inline-block;font-weight:bold;width:75%;", .class = "lbinfoTrt"})
        @Html.Label(Model.AgentEncodeur, htmlAttributes:=New With {.class = "infoTrt", .style = "width:75%;"})
        <br />
        @Html.Label("Contact", htmlAttributes:=New With {.style = "display:inline-block;font-weight:bold;width:75%;", .class = "lbinfoTrt"})
        @Html.Label(Model.AgentContact, htmlAttributes:=New With {.class = "infoTrt", .style = "width:75%;"})
        <br />
        @Html.Label("DPO", htmlAttributes:=New With {.style = "display:inline-block;font-weight:bold;width:75%;", .class = "lbinfoTrt"})
        @Html.Label(ViewBag.NomDPO.ToString(), htmlAttributes:=New With {.class = "infoTrt", .style = "width:75%;"})
    </div>
End Using