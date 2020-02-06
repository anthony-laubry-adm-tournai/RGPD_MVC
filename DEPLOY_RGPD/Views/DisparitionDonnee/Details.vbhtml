@ModelType RGPD_MVC.DisparitionDonnee
@Code
    ViewData("Title") = "Détails : disparition des données"
    Dim currentTrt As Traitement = CType(Session("trt"), Traitement)
    Dim currUsr As Utilisateur = CType(Session("Utilisateur"), Utilisateur)
End Code

@Using (Html.BeginForm("Test", "DisparitionDonnee", FormMethod.Post))
    @Html.AntiForgeryToken()
    @<div class="menu-2">
        <input type="text" value="@Session("TrtNom").ToString" name="NomTrt" class="nomTrt text-box single-line" />
        <hr class="hrMnu" />
        <div class="MnuContexte">CONTEXTE</div>
        <hr class="hrMnu" />

        <input type="submit" name="PrcpFond" value="- principe fondamentaux" class="linkButton mnuCreaPrcpFond" />

        <div class="mnuRisque">RISQUES</div>
        <hr class="hrMnu" />

        <input type="submit" name="MsrPrevue" value="- Mesure existante ou prévue" class="linkButton mnuCreaRisque" />
        <input type="submit" name="AccIll" value="- Accès illégitime à des données" class="linkButton mnuCreaRisque" />
        <input type="submit" name="ModNonDesi" value="- Modifications non désirées de données" class="linkButton mnuCreaRisque" />
        <input type="submit" name="DispDonn" value="- Disparition de données" class="linkButton mnuCreaRisque-current" />

        <hr class="hrMnu" />

        <input type="submit" name="Precedent" value="Précédent" class="btn btnMenu" />
        <hr class="hrMnu" style="margin-top:1%;" />

         @Select Case currUsr.Role.Id
                 Case 1
             @<input type="submit" name="retourAcc" value="Retour accueil" class="btn btnMenu" />
             If currentTrt.IsValid Then
             @<input type="submit" name="retourModif" value="Modifier" class="btn btnMenu" />
         End If
     Case 2
         If currentTrt.IsValid Then
             @<input type="submit" name="retourModif" value="Modifier" class="btn btnMenu" />
         Else
             @<input type="submit" name="Amodif" value="À modifier" class="btn btnMenu" />
             @<input type="submit" name="Valide" value="Validation DPO" class="btn btnMenu" />
         End If
     Case 3
         If currentTrt.IsValid Then
             @<input type="submit" name="retourModif" value="Modifier" class="btn btnMenu" />
         ElseIf currentTrt.ToControlContact Then
             @<input type="submit" name="retourAcc" value="Retour accueil" class="btn btnMenu" />
         Else
             @<input type="submit" name="Amodif" value="À modifier" class="btn btnMenu" />
             @<input type="submit" name="Valide" value="Valide" class="btn btnMenu" />
         End If
 End Select

         <hr class="hrMnu" />
         <div>
             @If ViewBag.ListeFichier IsNot Nothing Then
                     Dim lst As List(Of Fichier) = CType(ViewBag.ListeFichier, List(Of Fichier))
                     For Each item As Fichier In lst
                 @<div>
                     @If item.Nom.Length > 26 Then
                             Dim nom As String = item.Nom
                             nom = nom.Substring(0, 15) & "..." & nom.Substring(nom.Length - 8, 4) & nom.Substring(nom.LastIndexOf("."))
                         @Html.ActionLink(nom, "OpenPDF", "DisparitionDonnee", New With {.file = item.Path}, htmlAttributes:=New With {.name = "openPDF", .target = "_blank"})
                     Else
                         @Html.ActionLink(item.Nom, "OpenPDF", "DisparitionDonnee", New With {.file = item.Path}, htmlAttributes:=New With {.name = "openPDF", .target = "_blank"})
                     End If                    
                 </div>
                 @<br />
             Next
         End If
         </div>
    </div>

    @<div class="form-horizontal">
        <div style="border: 1px solid grey; text-align: center; margin-top: 1%; margin-bottom: 10px; padding-top: 10px; padding-bottom: 10px;">
            <span style="color: #FD4664; font-weight: bold;">Risques</span><br />
            <span style="font-size: 11px;">
                Cette section vous permet d'apprécier les risques sur la vie privée,
                <br />
                compte tenu des mesures existantes ou prévues.
            </span><br />
            <span style="color: #FD4664;">DISPARITION DE DONNÉES</span><br />
            <span style="font-size: 11px;">
                Analysez les causes et conséquences d'une disparition de données,
                <br />
                et estimez sa gravité et sa vraisemblance.
            </span>
        </div>

        @Html.Hidden("id", CLng(ViewContext.RouteData.Values("id")))
        <label style="font-weight:bold;">Quelles sont les principales <span style="color: #FD4664;">menaces</span> qui pourraient permettre la réalisation du risque ?</label><br />

        @code
            Dim sourceMenace As List(Of SourceMenace) = CType(ViewBag.SourceMenace, List(Of SourceMenace))

            For Each item As SourceMenace In sourceMenace
                If Model IsNot Nothing AndAlso Model.SourceMenace.Contains(item) Then
            @<div class="checkbox" style="margin-left:5%;">
                <input type="checkbox" name="srcMenace" value="@item.Id" checked="checked" /> <span class="chkDonnee control-label">@item.Libelle</span>
                @If Not String.IsNullOrEmpty(item.Tooltip) Then
                    @<img src="~/Img/interro.ico" class="curs" alt="" title="@item.Tooltip">
                End If
            </div>
        Else
            @<div class="checkbox" style="margin-left:5%;">
                <input type="checkbox" name="srcMenace" value="@item.Id" /> <span class="chkDonnee control-label">@item.Libelle</span>
                @If Not String.IsNullOrEmpty(item.Tooltip) Then
                    @<img src="~/Img/interro.ico" class="curs" alt="" title="@item.Tooltip">
                End If
            </div>
        End If
    Next
        End Code

        <label style="font-weight:bold;">Quelles <span style="color: #FD4664;">sources</span> de risques pourraient-elles en être à l'origine ?</label><br />

        @code
            Dim sourceRisque As List(Of SourceRisque) = CType(ViewBag.SourceRisque, List(Of SourceRisque))

            For Each item As SourceRisque In sourceRisque
                If Model IsNot Nothing AndAlso Model.SourceRisque.Contains(item) Then
            @<div class="checkbox" style="margin-left:5%;">
                <input type="checkbox" name="srcRisque" value="@item.Id" checked="checked" /> <span class="chkDonnee control-label">@item.Libelle</span>
                @If Not String.IsNullOrEmpty(item.Tooltip) Then
                    @<img src="~/Img/interro.ico" class="curs" alt="" title="@item.Tooltip">
                End If
            </div>
        Else
            @<div class="checkbox" style="margin-left:5%;">
                <input type="checkbox" name="srcRisque" value="@item.Id" /> <span class="chkDonnee control-label">@item.Libelle</span>
                @If Not String.IsNullOrEmpty(item.Tooltip) Then
                    @<img src="~/Img/interro.ico" class="curs" alt="" title="@item.Tooltip">
                End If
            </div>
        End If

    Next
        End Code

        <label style="font-weight:bold;">Quelles sont les <span style="color: #FD4664;">mesures</span>, parmi celles identifiées, qui contribuent à traiter le risque ?</label><br />

        @code
            Dim mesureRisque As List(Of MesureTraitement) = CType(ViewBag.MesureTraitement, List(Of MesureTraitement))

            For Each item As MesureTraitement In mesureRisque
                If Model IsNot Nothing AndAlso Model.MesureTraitement.Contains(item) Then
            @<div class="checkbox" style="margin-left:5%;">
                <input type="checkbox" name="msrRisque" value="@item.Id" checked="checked" /> <span class="chkDonnee control-label">@item.Titre</span>
                @If Not String.IsNullOrEmpty(item.Explication) Then
                    @<img src="~/Img/interro.ico" class="curs" alt="" title="@item.Explication">
                End If
            </div>
        Else
            @<div class="checkbox" style="margin-left:5%;">
                <input type="checkbox" name="msrRisque" value="@item.Id" /> <span class="chkDonnee control-label">@item.Titre</span>
                @If Not String.IsNullOrEmpty(item.Explication) Then
                    @<img src="~/Img/interro.ico" class="curs" alt="" title="@item.Explication">
                End If
            </div>
        End If

    Next
        End Code

        <label style="font-weight:bold;">Comment estimez-vous la <span style="color: #FD4664;">gravité du risque</span>, notamment en fonction des impacts potentiels et des mesures prévues ?</label>

        @code
            Dim listeGravite As List(Of Gravite) = CType(ViewBag.Gravite, List(Of Gravite))

            If Model IsNot Nothing Then
            @<div class="col-md-3" style="margin-left:5%;">
                @Html.DropDownListFor(Function(model) model.IdGravite, _
                    New SelectList(listeGravite, "Id", "Libelle", Model.IdGravite), _
                    htmlAttributes:=New With {.class = "form-control"})

                @Html.ValidationMessageFor(Function(model) model.IdGravite, "", New With {.class = "text-danger"})
            </div>
        Else
            @<div class="col-md-3" style="margin-left:5%;">
                @Html.DropDownListFor(Function(model) model.IdGravite, _
                    New SelectList(listeGravite, "Id", "Libelle"), _
                    htmlAttributes:=New With {.class = "form-control"})

                @Html.ValidationMessageFor(Function(model) model.IdGravite, "", New With {.class = "text-danger"})
            </div>
        End If
        End Code

        <label style="font-weight:bold;">Comment estimez-vous la <span style="color: #FD4664;">vraisemblance du risque</span>, notamment au regard des menaces, des sources de risques et des mesures prévues ?</label>

        @code
            Dim listeVraisemblance As List(Of Vraisemblance) = CType(ViewBag.Vraisemblance, List(Of Vraisemblance))
            If Model IsNot Nothing Then
            @<div class="col-md-3" style="margin-left:5%;">
                @Html.DropDownListFor(Function(model) model.IdVraisemblance, _
                    New SelectList(listeVraisemblance, "Id", "Libelle", Model.IdVraisemblance), _
                    htmlAttributes:=New With {.class = "form-control"})

                @Html.ValidationMessageFor(Function(model) model.IdVraisemblance, "", New With {.class = "text-danger"})
            </div>
        Else
            @<div class="col-md-3" style="margin-left:5%;">
                @Html.DropDownListFor(Function(model) model.IdVraisemblance, _
                    New SelectList(listeVraisemblance, "Id", "Libelle"), _
                    htmlAttributes:=New With {.class = "form-control"})

                @Html.ValidationMessageFor(Function(model) model.IdVraisemblance, "", New With {.class = "text-danger"})
            </div>
        End If
        End Code
    </div>
End Using
