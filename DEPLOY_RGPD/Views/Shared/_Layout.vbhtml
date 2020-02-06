<!DOCTYPE html>
<html>
@code
    Dim ctx As New RegistreTraitementContext
    Dim role As Role = Nothing
End Code
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Gestion du registre des traitements</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

    <link href="~/Content/themes/base/jquery-ui.min.css" rel="stylesheet" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
</head>
<body>
    <div class="navbar navbar-default">
        <div class="navbar-header" style="min-width:1366px;">
            @If Session("Utilisateur") IsNot Nothing Then
                @<div class="image">
                    <img src="~/img/logoMini.png" alt="Smiley face" height="80" width="80" />
                </div>
                @Html.ActionLink("Gestion du registre des traitements", "Index", "Traitement", New With {.area = ""}, New With {.class = "navbar-brand LabelTitre"})
            End If
        </div>

        @If Session("Utilisateur") IsNot Nothing Then
            @<div class="bandeau">
                @Html.ActionLink("Accueil", "Index", "Traitement", New With {.area = ""}, New With {.class = "lienAccueil"})
                @code

                If Session("Utilisateur") IsNot Nothing Then
                Dim usr As Utilisateur = CType(Session("Utilisateur"), Utilisateur)
                role = ctx.Role.FirstOrDefault(Function(x) x.Id = usr.IdRole)

                If role IsNot Nothing Then
                    @<div class="lienAgent">@role.Libelle : @usr.DisplayName || Service : @usr.Service.Libelle</div>
                End If
                End If

                End Code
                @Html.ActionLink("Déconnexion", "Disconnect", "Login", New With {.area = ""}, New With {.class = "lienDeconnexion"})
            </div>
        End If
    </div>

    <div class="menu">
        @If (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("Traitement") AndAlso _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("action").ToString().ToLower.Equals("index") OrElse _
             HttpContext.Current.Request.RequestContext.RouteData.Values("action").ToString().ToLower.Equals("indexdesactive"))) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("GestionRole")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("SupportDonnee")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("LegitimationCaracterePersonnel")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("LegitimationCaractereSensible")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("FinaliteDonnee")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("DureeConservationDonnee")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("PersonneConcernee")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("DonneeCaracterePersonnel")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("DonneeCaractereSensible")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("ExportPDF")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("SourceMenace")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("SourceRisque")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("Gravite")) OrElse _
            (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().Equals("Vraisemblance")) Then
            @If role IsNot Nothing Then
                @If role.Libelle.ToLower.Equals("agent") Then
                    @Html.ActionLink("Créer traitement", "create", "Traitement", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                ElseIf role.Libelle.ToLower.Equals("contact") Then
                    @Html.ActionLink("Créer traitement", "create", "Traitement", "", htmlAttributes:=New With {.class = "btn btnMenu "})@<br />
                    If HttpContext.Current.Request.RequestContext.RouteData.Values("action").ToString().ToLower.Equals("indexdesactive") Then
                    @Html.ActionLink("Traitement(s) actif(s)", "Index", "Traitement", "", htmlAttributes:=New With {.class = "btn btnMenu "})@<br />
                    Else
                    @Html.ActionLink("Traitement(s) désactivé(s)", "IndexDesactive", "Traitement", "", htmlAttributes:=New With {.class = "btn btnMenu "})@<br />
                    End If

                    @Html.ActionLink("Exportation PDF", "Index", "ExportPDF","", htmlAttributes:=New With {.class = "btn btnMenu "})
                ElseIf role.Libelle.ToLower.Equals("dpd") Then
                    @Html.ActionLink("Créer traitement", "create", "Traitement", "", htmlAttributes:=New With {.class = "btn btnMenu "})@<br />
                    @Html.ActionLink("Affecter rôle", "GererRole", "GestionRole", "", htmlAttributes:=New With {.class = "btn btnMenu"})@<br />

                    @<ul style="list-style-type: none;padding-left:0px;">
                        <li class="accordion btn btnMenu"><a id='lbGestGloss'>Gestion du glossaire</a></li>
                        <li class="panel sousMenuConteneur">
                            <ul style="list-style-type: none;padding-left:0px;">
                                <li class="accordion btn btnMenu">Support des données</li>
                                <li class="panel sousMenuConteneur">
                                    <ul style="list-style-type: none;padding-left:0px;">
                                        @Html.ActionLink("Ajouter","Create","SupportDonnee","",htmlAttributes:=New With{.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "SupportDonnee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "SupportDonnee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                    </ul>
                                </li>

                                <li class="accordion btn btnMenu">Légitimation personnel</li>
                                <li class="panel sousMenuConteneur">
                                    <ul style="list-style-type: none;padding-left:0px;">
                                        @Html.ActionLink("Ajouter", "Create", "LegitimationCaracterePersonnel", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "LegitimationCaracterePersonnel", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "LegitimationCaracterePersonnel", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                    </ul>
                                </li>

                                <li class="accordion btn btnMenu">Légitimation sensible</li>
                                <li class="panel sousMenuConteneur">
                                     <ul style="list-style-type: none;padding-left:0px;">
                                         @Html.ActionLink("Ajouter", "Create", "LegitimationCaractereSensible", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                         @Html.ActionLink("Modifier", "Edit", "LegitimationCaractereSensible", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                         @Html.ActionLink("Supprimer", "Delete", "LegitimationCaractereSensible", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                     </ul>
                                </li>

                                <li class="accordion btn btnMenu">Finalité des données</li>
                                <li class="panel sousMenuConteneur">
                                     <ul style="list-style-type: none;padding-left:0px;">
                                         @Html.ActionLink("Ajouter", "Create", "FinaliteDonnee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "FinaliteDonnee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "FinaliteDonnee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                     </ul>
                                 </li>

                                <li class="accordion btn btnMenu">Conservation des données</li>
                                <li class="panel sousMenuConteneur">
                                    <ul style="list-style-type: none;padding-left:0px;">
                                        @Html.ActionLink("Ajouter", "Create", "DureeConservationDonnee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "DureeConservationDonnee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "DureeConservationDonnee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                    </ul>
                                </li>

                                <li class="accordion btn btnMenu">Personne concernée</li>
                                <li class="panel sousMenuConteneur">
                                    <ul style="list-style-type: none;padding-left:0px;">
                                        @Html.ActionLink("Ajouter", "Create", "PersonneConcernee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "PersonneConcernee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "PersonneConcernee", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                    </ul>
                                </li>

                                <li class="accordion btn btnMenu">Données personnels</li>
                                <li class="panel sousMenuConteneur">
                                    <ul style="list-style-type: none;padding-left:0px;">
                                        @Html.ActionLink("Ajouter", "Create", "DonneeCaracterePersonnel", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "DonneeCaracterePersonnel", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "DonneeCaracterePersonnel", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                    </ul>
                                </li>

                                <li class="accordion btn btnMenu">Données sensibles</li>
                                <li class="panel sousMenuConteneur">
                                    <ul style="list-style-type: none;padding-left:0px;">
                                        @Html.ActionLink("Ajouter", "Create", "DonneeCaractereSensible", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "DonneeCaractereSensible", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "DonneeCaractereSensible", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                    </ul>
                                </li>

                                <li class="accordion btn btnMenu">Sources des menaces</li>
                                <li class="panel sousMenuConteneur">
                                    <ul style="list-style-type: none;padding-left:0px;">
                                        @Html.ActionLink("Ajouter", "Create", "SourceMenace", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "SourceMenace", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "SourceMenace", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                    </ul>
                                </li>

                                <li class="accordion btn btnMenu">Sources des risques</li>
                                <li class="panel sousMenuConteneur">
                                    <ul style="list-style-type: none;padding-left:0px;">
                                        @Html.ActionLink("Ajouter", "Create", "SourceRisque", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "SourceRisque", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "SourceRisque", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                    </ul>
                                </li>

                                <li class="accordion btn btnMenu">Gravité</li>
                                <li class="panel sousMenuConteneur">
                                    <ul style="list-style-type: none;padding-left:0px;">
                                        @Html.ActionLink("Ajouter", "Create", "Gravite", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "Gravite", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "Gravite", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                    </ul>
                                </li>

                                <li class="accordion btn btnMenu">Vraisemblance</li>
                                <li class="panel sousMenuConteneur">
                                    <ul style="list-style-type: none;padding-left:0px;">
                                        @Html.ActionLink("Ajouter", "Create", "Vraisemblance", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Modifier", "Edit", "Vraisemblance", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                        @Html.ActionLink("Supprimer", "Delete", "Vraisemblance", "", htmlAttributes:=New With {.class = "btn btnMenu "})
                                    </ul>
                                </li>
                            </ul>
                         </li>
                    </ul>

                    If HttpContext.Current.Request.RequestContext.RouteData.Values("action").ToString().ToLower.Equals("indexdesactive") Then
                    @Html.ActionLink("Traitement(s) actif(s)", "Index", "Traitement","", htmlAttributes:=New With {.class = "btn btnMenu "})@<br />
                    Else
                    @Html.ActionLink("Traitement(s) désactivé(s)", "IndexDesactive", "Traitement","", htmlAttributes:=New With {.class = "btn btnMenu "})@<br />
                    End If
                    @Html.ActionLink("Exportation PDF", "Index", "ExportPDF","", htmlAttributes:=New With {.class = "btn btnMenu "})
                End If
            End If
        End If
    </div>

    @If Session("Utilisateur") IsNot Nothing AndAlso _
        (HttpContext.Current.Request.RequestContext.RouteData.Values("controller").ToString().ToLower.Equals("traitement") AndAlso _
            HttpContext.Current.Request.RequestContext.RouteData.Values("action").ToString().ToLower.Equals("index")) Then
        @<div id="legendeTr">
            <table style="padding-left:15px">
                <tr>
                    <td>
                        <div class='isValid' title='Traitement valide'></div>
                    </td>
                    <td>
                        &nbsp; Validé
                    </td>
                </tr>

                <tr>
                    <td>
                        <div class='modif' title='Traitement à modifier'></div>
                    </td>
                    <td>
                        &nbsp; A modifier
                    </td>
                </tr>

                <tr>
                    <td>
                        <div class='toBeControledContact' title='Traitement en attente de validation par le Contact RGPD du service'></div>
                    </td>
                    <td>
                        &nbsp; En attente de validation - Contact
                    </td>
                </tr>

                <tr>
                    <td>
                        <div class='toBeControledDPD' title='Traitement en attente de validation par le/la DPD'></div>
                    </td>
                    <td>
                        &nbsp; En attente de validation - DPO
                    </td>
                </tr>
            </table>
        </div>
    End If

    <div class="container body-content" style="margin-left:20%;">
        @RenderBody()
        <hr style="margin-left:2%;" />
        <footer style="margin-left:2%;">
            <p>&copy; @DateTime.Now.Year - Administration Communale de la Ville de Tournai - C.P.A.S. de Tournai</p>
        </footer>
    </div>

    @*Lorsque je mets à jour des scripts je dois faire attention au fait que le layout ne va pas s'updater tout seul*@
    <script src="~/Scripts/jquery-3.3.1.min.js"></script>
    @*Jquery UI DOIT venir après Jquery et avant bootstrap*@
    <script src="~/Scripts/jquery-ui-1.12.1.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>

    <script>       
        var acc = document.getElementsByClassName("accordion");
        var i;

        for (i = 0; i < acc.length; i++) {
            acc[i].addEventListener("click", function () {
                this.classList.toggle("active");
                var panel = this.nextElementSibling;
                if (panel.style.display === "block") {
                    panel.style.display = "none";
                } else {
                    panel.style.display = "block";
                }
            });
        }

        $(function () {
            $(".date-picker").datepicker({
                changeMonth: true,
                changeYear: true,
                monthNamesShort: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin', 'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'],
                dayNamesMin: ['Dim', 'Lun', 'Mar', 'Mer', 'Jeu', 'Ven', 'Sam'],
                dateFormat: 'dd-mm-yy'
            });

        });
    </script>



    @RenderSection("scripts", required:=False)
</body>
</html>