@ModelType RGPD_MVC.Incident
@Code
    ViewData("Title") = "Details"
    Dim currentUsr As Utilisateur = CType(Session("Utilisateur"), Utilisateur)
    Dim lstLieu As List(Of LieuIncident) = CType(ViewBag.LieuIncident, List(Of LieuIncident))
    Dim lstCause As List(Of CauseIncident) = CType(ViewBag.CauseIncident, List(Of CauseIncident))
    Dim lstType As List(Of TypeIncident) = CType(ViewBag.TypeIncident, List(Of TypeIncident))
End Code

<style>
    .handHover {
        cursor: pointer;
    }

    .dateSize {
        max-width: 110px;
        width: 100%;
    }

</style>
<h2>Détails de la déclaration d'un incident</h2>

<div class="form-horizontal">
    @*<h4>Incident</h4>*@
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

    <div class="row">
        @Html.LabelFor(Function(model) model.Nom, htmlAttributes:=New With {.class = "control-label col-md-2 bold", .style = "text-align:left;"})
        <div class="col-md-6">
            @Html.EditorFor(Function(model) model.Nom, New With {.htmlAttributes = New With {.class = "form-control", .style = "margin-left:40px;width:393px;max-width:100%;", .readonly="readonly"}})
            @Html.ValidationMessageFor(Function(model) model.Nom, "", New With {.class = "text-danger"})
        </div>

        @Html.LabelFor(Function(model) model.DateCreation, htmlAttributes:=New With {.class = "control-label col-md-2 bold"})
        <div class="col-md-2">
            @Html.EditorFor(Function(model) model.DateCreation, New With {.htmlAttributes = New With {.class = "form-control dateSize", .readonly = "readonly"}})
            @Html.ValidationMessageFor(Function(model) model.DateCreation, "", New With {.class = "text-danger"})
        </div>
    </div>

    <br />

    <div class="row">
        @Html.LabelFor(Function(model) model.DateConstat, htmlAttributes:=New With {.class = "control-label col-md-3 bold", .style = "text-align:left;"})
        <div class="col-md-2">
            @Html.EditorFor(Function(model) model.DateConstat, New With {.htmlAttributes = New With {.class = "form-control date-picker handHover dateSize", .style = "margin-left:-55px;", .readonly = "readonly"}})
            @Html.ValidationMessageFor(Function(model) model.DateConstat, "", New With {.class = "text-danger"})
        </div>

        @Html.LabelFor(Function(model) model.DateIncident, htmlAttributes:=New With {.class = "control-label col-md-2 bold", .style = "margin-left:-113px;"})
        <div class="col-md-2">
            @Html.EditorFor(Function(model) model.DateIncident, New With {.htmlAttributes = New With {.class = "form-control date-picker handHover dateSize", .style = "margin-left:-40px;", .readonly = "readonly"}})
            @Html.ValidationMessageFor(Function(model) model.DateIncident, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />

    <div class="row">
        @Html.LabelFor(Function(model) model.IdCauseIncident, htmlAttributes:=New With {.class = "control-label col-md-2 bold"})
        <div class="col-md-10">
            @Html.DropDownList("IdCauseIncident", _
                                    New SelectList(lstCause, _
                                                         "Id", _
                                                         "Libelle", Model.IdCauseIncident), _
                                          htmlAttributes:=New With {.class = "form-control handHover", .style = "margin-left:40px;max-width:220px;", .Name = "IdCauseIncident", .readonly = "readonly"})
            @*@Html.EditorFor(Function(model) model.IdCauseIncident, New With {.htmlAttributes = New With {.class = "form-control"}})*@
            @Html.ValidationMessageFor(Function(model) model.IdCauseIncident, "", New With {.class = "text-danger"})
        </div>
    </div>

    <br />
    <div class="row">
        @Html.LabelFor(Function(model) model.Description, htmlAttributes:=New With {.class = "control-label col-md-2 bold", .style = "text-align:left;"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Description, New With {.htmlAttributes = New With {.class = "form-control", .style = "margin-left:40px;max-width:393px;width:100%;min-height:150px;height:100%;", .readonly = "readonly"}})
            @Html.ValidationMessageFor(Function(model) model.Description, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />

    <div class="row">
        @Html.Label("Type d'incident", htmlAttributes:=New With {.class = "control-label col-md-12 bold", .style = "text-align:center;text-decoration:underline;"})
        <br />
        @code
            Dim txtAutre As String = String.Empty
            Dim typeIncident_incident As TypeIncident_Incident = Nothing
        End Code
        @For Each _type As TypeIncident In lstType
            @code
            typeIncident_incident = Model.TypeIncident_Incident.FirstOrDefault(Function(x) x.IdTypeIncident = _type.Id AndAlso x.IdIncident = Model.Id)
            If typeIncident_incident IsNot Nothing AndAlso Not String.IsNullOrEmpty(typeIncident_incident.TxtAutre) Then
                txtAutre = typeIncident_incident.TxtAutre
            End If
            End Code
            @<div class="col-md-6">
                @If Model.TypeIncident_Incident.Select(Function(x) x.IdTypeIncident).Contains(_type.Id) Then
                    @Html.CheckBox("typeIncident", True, htmlAttributes:=New With {.value = _type.Id, .id = _type.Libelle, .disabled = "disabled"})
                Else
                    @Html.CheckBox("typeIncident", False, htmlAttributes:=New With {.value = _type.Id, .id = _type.Libelle, .disabled = "disabled"})
                End If

                @Html.Label(_type.Libelle, htmlAttributes:=New With {.for = _type.Libelle, .class = "handHover"})
            </div>
        Next
        @*<div class="col-md-6">
                @Html.DropDownList("IdTypeIncident", _
                                          New SelectList(lstType, _
                                                         "Id", _
                                                         "Libelle", 1), _
                                          htmlAttributes:=New With {.class = "form-control handHover", .style = "margin-left:40px;max-width:520px;", .Name = "IdTypeIncident"})
            </div>*@
    </div>
    <br />

    <div id="DescrTypeIncident" class="row">
        @Html.Label("Description « type d'incident »", htmlAttributes:=New With {.class = "control-label col-md-3 bold"})
        <div class="col-md-6">
            @If Not String.IsNullOrEmpty(txtAutre) Then
                @Html.TextArea("TxtAutre", txtAutre, htmlAttributes:=New With {.class = "form-control", .style = "margin-left:-55px;max-width:393px;width:100%;min-height:150px;height:100%;", .readonly = "readonly"})
            Else
                @Html.TextArea("TxtAutre", htmlAttributes:=New With {.class = "form-control", .style = "margin-left:-55px;max-width:393px;width:100%;min-height:150px;height:100%;", .readonly = "readonly"})
            End If

        </div>
    </div>
    <br />

    <div class="row">
        @Html.LabelFor(Function(model) model.IdLieuIncident, htmlAttributes:=New With {.class = "control-label col-md-2 bold"})

        <div class="col-md-6">
            @Html.DropDownList("IdLieuIncident", _
                                          New SelectList(lstLieu, _
                                                         "Id", _
                                                         "Libelle", Model.IdLieuIncident), _
                                          htmlAttributes:=New With {.class = "form-control handHover", .style = "margin-left:40px;max-width:220px;", .Name = "IdLieuIncident", .readonly = "readonly"})
        </div>
    </div>
    <br />

    <div id="descrLieuInci" class="row">
        @Html.LabelFor(Function(model) model.TxtDescrLieuIncident, htmlAttributes:=New With {.class = "control-label col-md-3 bold", .style = "width:220px;width:100%;"})
        <div class="col-md-8">
            @Html.EditorFor(Function(model) model.TxtDescrLieuIncident, New With {.htmlAttributes = New With {.class = "form-control", .style = "margin-left:-55px;max-width:393px;width:100%;min-height:150px;height:100%;", .readonly = "readonly"}})
            @Html.ValidationMessageFor(Function(model) model.TxtDescrLieuIncident, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />

    @If Model.IsInfoPersConcerne then'currentUsr.Role.Id = 3 Then
        @<div class="row">
            @Html.LabelFor(Function(model) model.IsInfoPersConcerne, htmlAttributes:=New With {.class = "control-label col-md-3 bold"})
            <div class="col-md-9">
                <div class="checkbox">
                    @Html.EditorFor(Function(model) model.IsInfoPersConcerne, New With {.htmlattributes = New With {.style = "width:30px;height:30px;", .readonly = "readonly"}})
                    @Html.ValidationMessageFor(Function(model) model.IsInfoPersConcerne, "", New With {.class = "text-danger"})
                </div>
            </div>
        </div>
    End If

    <div id="infoPersConcerne" style="margin-left:100px;">
        <div class="row">
            @Html.LabelFor(Function(model) model.DateInfoPersConcerne, htmlAttributes:=New With {.class = "control-label col-md-3 bold"})
            <div class="col-md-9">
                @Html.EditorFor(Function(model) model.DateInfoPersConcerne, New With {.htmlAttributes = New With {.class = "form-control date-picker handHover dateSize", .style = "margin-left:-87px;", .readonly = "readonly"}})
                @Html.ValidationMessageFor(Function(model) model.DateInfoPersConcerne, "", New With {.class = "text-danger"})
            </div>
        </div>
        <br />
        <div class="row">
            @Html.LabelFor(Function(model) model.TxtInfoPersConcerne, htmlAttributes:=New With {.class = "control-label col-md-2 bold"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.TxtInfoPersConcerne, New With {.htmlAttributes = New With {.class = "form-control", .style = "min-height:150px;height:100%;max-width:350px;width:100%;", .readonly = "readonly"}})
                @Html.ValidationMessageFor(Function(model) model.TxtInfoPersConcerne, "", New With {.class = "text-danger"})
            </div>
        </div>
    </div>

    @If Model.IsInfoAutorite then 'currentUsr.Role.Id = 3 Then
        @<br />

        @<div class="row">
            @Html.LabelFor(Function(model) model.IsInfoAutorite, htmlAttributes:=New With {.class = "control-label col-md-3 bold"})
            <div class="col-md-9">
                <div class="checkbox">
                    @Html.EditorFor(Function(model) model.IsInfoAutorite, New With {.htmlattributes = New With {.style = "width:30px;height:30px;", .readonly = "readonly"}})
                    @Html.ValidationMessageFor(Function(model) model.IsInfoAutorite, "", New With {.class = "text-danger"})
                </div>
            </div>
        </div>
    End If

    <div id="infoAutorite" style="margin-left:100px;">
        <div class="row">
            @Html.LabelFor(Function(model) model.DateInfoAutorite, htmlAttributes:=New With {.class = "control-label col-md-3 bold"})
            <div class="col-md-9">
                @Html.EditorFor(Function(model) model.DateInfoAutorite, New With {.htmlAttributes = New With {.class = "form-control date-picker handHover dateSize", .style = "margin-left:-87px;", .readonly = "readonly"}})
                @Html.ValidationMessageFor(Function(model) model.DateInfoAutorite, "", New With {.class = "text-danger"})
            </div>
        </div>
        <br />
        <div class="row">
            @Html.LabelFor(Function(model) model.IdFichierIncident, htmlAttributes:=New With {.class = "control-label col-md-2 bold"})
            @If ViewBag.CheminFichier IsNot Nothing Then
                @<div class="col-md-10">@Html.ActionLink(ViewBag.CheminFichier.Nom, "Download", "Incident", New With {.param = Server.MapPath(ViewBag.CheminFichier.Path)}, htmlAttributes:=New With {.target = "_blank"})</div>
            End If
   
        </div>
    </div>

    <br />
    
     <div class="row">
         @Html.LabelFor(Function(model) model.CommentaireDPO, htmlAttributes:=New With {.class = "control-label col-md-2 bold"})
         <div class="col-md-10">
             @Html.EditorFor(Function(model) model.CommentaireDPO, New With {.htmlAttributes = New With {.class = "form-control", .style = "margin-left:40px;max-width:393px;width:100%;min-height:150px;height:100%;", .readonly = "readonly"}})
             @Html.ValidationMessageFor(Function(model) model.CommentaireDPO, "", New With {.class = "text-danger"})
         </div>
     </div>

    <br />
</div>

<p>
    <a href="/Traitement/Index">Retour</a>
</p>

@*Lorsque je mets à jour des scripts je dois faire attention au fait que le layout ne va pas s'updater tout seul*@
<script src="~/Scripts/jquery-3.3.1.min.js"></script>
@*Jquery UI DOIT venir après Jquery et avant bootstrap*@
<script src="~/Scripts/jquery-ui-1.12.1.min.js"></script>
<script src="~/Scripts/bootstrap.min.js"></script>
<script>
    $(function () {
        if ($('#IsInfoPersConcerne').is(':checked')) {
            $('#infoPersConcerne').show();
        } else {
            $('#infoPersConcerne').hide();
        }

        if ($('#IsInfoAutorite').is(':checked')) {
            $('#infoAutorite').show();
        } else {
            $('#infoAutorite').hide();
        }

        $('input[name=typeIncident]').each(function (e) {
            var val = $(this).attr('id');
            if (val)
            {
                if (val.indexOf('Autre') >= 0 && $(this).is(':checked')) {
                    $('#DescrTypeIncident').show();
                    return false;
                }
                else {
                    $('#DescrTypeIncident').hide();
                }
            }
            else
            {
                $('#DescrTypeIncident').hide();
            }

        });

        var selectLieu = $("#IdLieuIncident option:selected").text();
        if (selectLieu) {
            if (selectLieu.indexOf('Autre') >= 0) {
                $('#descrLieuInci').show();
            }
            else {
                $('#descrLieuInci').hide();
            }
        } else {
            $('#descrLieuInci').hide();
        }
    });
</script>