@Code
    ViewData("Title") = "Exportation de(s) traitement(s)"
End Code

<h2 style="text-decoration:underline;">Exportation de(s) traitement(s) en PDF.</h2>

<br />

@Using (Html.BeginForm("Export", "ExportPDF"))
    @<div class="table">
        <div class="custom-checkbox">
            @Html.CheckBox("Tous", False, htmlAttributes:=New With {.title = "Si ""Tous"" est coché l'ensemble des traitements sera exporté. Sinon seul les valides le seront."})
            <label title="Si  'Tous'  est coché l'ensemble des traitements sera exporté. Sinon seul les valides le seront.">Tous</label>
        </div>
        <div class="row">
            <div class="col-md-3">
                <h4>Tous les traitements</h4>
                <br /><br /><br />
                <input name="ExportAll" type="submit" class="btn btnMenu" value="Exporter" style="margin-top:30.5px;" />
            </div>

            <div class="col-md-5">
                <h4>Tous les traitements d'un service</h4>
                @Html.DropDownList("idService", New SelectList(CType(ViewBag.Service, List(Of Service)), "Id", "Libelle"), htmlAttributes:=New With {.class = "form-control"})
                <br /><br />
                <input name="ExportAllByService" type="submit" class="btn btnMenu" value="Exporter" style="margin-top:16.5px;" />
            </div>

            <div class="col-md-4">
                <h4>Un traitement</h4>
                @If ViewBag.SelectedService IsNot Nothing Then
                    @Html.DropDownList("ListeService", New SelectList(CType(ViewBag.Service, List(Of Service)), "Id", "Libelle", ViewBag.SelectedService), htmlAttributes:=New With {.class = "form-control", .onchange = "this.form.submit();"})
                    ViewBag.SelectedService = String.Empty
                Else
                    @Html.DropDownList("ListeService", New SelectList(CType(ViewBag.Service, List(Of Service)), "Id", "Libelle"), htmlAttributes:=New With {.class = "form-control", .onchange = "this.form.submit();"})
                End If
                <br />
                @Html.DropDownList("ListeTrt", New SelectList(CType(ViewBag.TraitementServices, List(Of Traitement)), "Id", "Nom"), htmlAttributes:=New With {.class = "form-control", .style = "display:inline-block;", .id = "ListeTrt"})
                <br />
                <input name="ExportOneTrt" type="submit" class="btn btnMenu" value="Exporter" />
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-5">
                <h4>Tous les traitements entre deux dates</h4>
            </div>
        </div>

        <div class="row">
            <div class="col-md-5">
                <h6>Date de début</h6>
            </div>
            <div class="col-md-6">
                <h6 style="margin-left:28px;">Date de fin</h6>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">

                <div id="_dateDebut" name="_dateDebut" class="text-box single-line form-control date-picker" style="min-height:265px;max-width:400px;display:inline-block;">
                    @Html.Hidden("dateDebut")
                </div>

                <span style="margin-left:100px;"></span>
                <div id="_dateFin" name="_dateFin" class="text-box single-line form-control date-picker" style="min-height:265px;max-width:400px;display:inline-block;">
                    @Html.Hidden("dateFin")
                </div>
                <br />
                <input name="ExportBetweenDate" class="btn btnMenu" type="submit" value="Exporter" />
            </div>
        </div>


    </div>
End Using

<script src="~/Scripts/jquery-3.3.1.min.js"></script>
@*Jquery UI DOIT venir après Jquery et avant bootstrap*@
<script src="~/Scripts/jquery-ui-1.12.1.min.js"></script>
<script>
    $("document").ready(function () {

        //$("#ExportAllFromService").on("click", function () {
        //    $.post("/ExportPDF/ExportAllFromService", { ListeServiceSeul: $('#ListeServiceSeul').val()}, function (x) {
        //    });
        //});
        //$("#betweenDate").on("click", function () {
        //    $.post("/ExportPDF/ExportAllBetweenDate", { dateDeb: $('#dateDebut').val(), dateFin: $('#dateFin').val() }, function (x) {
        //    });
        //});

        //$("#ListeServiceSeul").on("click", function () {
        //    $.post("/ExportPDF/ExportAllFromService", { ListeServiceSeul: $('#ListeServiceSeul').val()}, function (x) {
        //    });
        //});

        //$("#oneTrt").on("click", function () {
        //    $.post("/ExportPDF/ExportOneTrt", { ListeTrt: $('#ListeTrt').val() }, function (x) {
        //    });
        //});

        //$("#ExportBetweenDate").on("click", function () {
        //    $.post("/ExportPDF/Export", {idService:'0',action:'',ListeService:'',ListeTrt:'', dateDebut: $('#dateDebut').val(), dateFin: $('#dateFin').val(), ExportBetweenDate:"Exporter" }, function (x) {
        //    });
        //});

        $("#dateDebut").val('@DateTime.Now.ToString("dd-MM-yyyy")');
        $("#dateFin").val('@DateTime.Now.ToString("dd-MM-yyyy")');

        $(document).on('change', '#_dateDebut', function () {
            $('#dateDebut').val($('#_dateDebut').val());
        });

        $(document).on('change', '#_dateFin', function () {
            $('#dateFin').val($('#_dateFin').val());
        });

        $("#ListeService").on("change", function () {
            $.post("/ExportPDF/RemplitListeTraitementService", { action: "populate", idService: $('#ListeService').val() }, function (x) {
            });
        });
    });
</script>