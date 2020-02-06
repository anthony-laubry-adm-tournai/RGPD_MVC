@ModelType RGPD_MVC.DisparitionDonnee
@Code
    ViewData("Title") = "Édition : disparition des données"
    Dim currentTrt As Traitement = CType(Session("trt"), Traitement)
    Dim currUsr As Utilisateur = CType(Session("Utilisateur"), Utilisateur)
End Code

@Using (Html.BeginForm("Edit", "DisparitionDonnee", FormMethod.Post, New With {.enctype = "multipart/form-data"}))
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
        <input type="submit" id="AccIll" name="AccIll" value="- Accès illégitime à des données" class="linkButton mnuCreaRisque" />
        <input type="submit" id="ModNonDesire" name="ModNonDesi" value="- Modifications non désirées de données" class="linkButton mnuCreaRisque" />
        <input type="submit" id="DispDonn" name="DispDonn" value="- Disparition de données" class="linkButton mnuCreaRisque-current" />

        <hr class="hrMnu" />

        @Html.ActionLink("Annuler", "Index", "Traitement", "", htmlAttributes:=New With {.class = "btn btnMenu "})
        <input type="submit" name="Precedent" value="Précédent" class="btn btnMenu" />
        <hr class="hrMnu" style="margin-top:1%;" />
        @If currentTrt.ToModify Then
            @<input type="submit" name="ValidCtc" value="Validation contact" class="btn btnMenu" />
        ElseIf currentTrt.ToControlContact Then
            If currUsr.Service.Id = currentTrt.Service.Id Then
            @<input type="submit" name="toModif" value="A modifier" class="btn btnMenu" />
            @<input type="submit" name="ValidDpo" value="Validation DPO" class="btn btnMenu" />
        End If
    End If

        @If currentTrt.ToModify Then
            @<br />@<span style="font-weight:bold;color:red;padding-left:107.5px;">OU</span>@<br />
            @<input type="submit" value="Enregistrer" class="btn btnMenu" />
        End If

         <hr class="hrMnu" />

         @Html.Label("Pièce jointe", htmlAttributes:=New With {.style = "color:#3EE095;font-weight:bold;"})
         <input type="file" name="file" accept="application/pdf" />
         <input type="submit" name="uploadFile" value="Uploader le fichier" class="btn btnMenu" />
         @If Session("uploadSuccess") IsNot Nothing Then
             @Html.Label(Session("uploadSuccess").ToString, htmlAttributes:=New With {.style = "color:#3EE095;font-weight:bold;"})
             Session("uploadSuccess") = String.Empty
         End If

         <hr class="hrMnu" />
         <div>
             @If ViewBag.listeFichier IsNot Nothing Then
                     Dim lst As List(Of Fichier) = CType(ViewBag.ListeFichier,List(Of Fichier))
                     For Each item As Fichier In lst
                 @<div>
                     @If item.Nom.Length > 26 Then
                             Dim nom As String = item.Nom
                             nom = nom.Substring(0, 15) & "..." & nom.Substring(nom.Length - 8, 4) & nom.Substring(nom.LastIndexOf("."))
                         @Html.ActionLink(nom, "OpenPDF", "DisparitionDonnee", New With {.file = item.Path}, htmlAttributes:=New With {.name = "openPDF", .target = "_blank"})
                     Else
                         @Html.ActionLink(item.Nom, "OpenPDF", "DisparitionDonnee", New With {.file = item.Path}, htmlAttributes:=New With {.name = "openPDF", .target = "_blank"})
                     End If
                     @*<br />*@
                     @Html.ActionLink("Supprimer", "DeleteDoc", "DisparitionDonnee", New With {.id = item.Id, .idTrt = item.IdTraitement}, htmlAttributes:=New With {.class = "boutonSup"})
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
