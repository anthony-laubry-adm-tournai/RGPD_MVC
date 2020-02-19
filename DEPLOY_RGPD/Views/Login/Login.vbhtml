@ModelType RGPD_MVC.Login
@Code
    ViewData("Title") = "Connexion"
End Code

<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Exo:100,200,400">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Source+Sans+Pro:700,400,300">
<style>
    .centrerLabelNom {
        position: absolute;
        top: calc(39%);
        left: calc(47.2% );
        z-index: 2;
        font-family: 'Exo', sans-serif;
        font-size: 15px;
    }

    .centrerLabelMdp {
        position: absolute;
        top: calc(61%); 
        left: calc(47.2%);
        z-index: 2;
        font-family: 'Exo', sans-serif;
        font-size: 15px;
    }
   
    .centrerBt {
        position: absolute;
        top: calc(82%);
        left: calc(47.2%);
        z-index: 2;
        font-family: 'Exo', sans-serif;
        font-size: 15px;
        margin-top:25px;
    }

    .conSel{
        position: absolute;
        top: calc(82%);
        left: calc(47.2%);
        z-index: 2;
        font-family: 'Exo', sans-serif;
        font-size: 15px;
        margin-left:25px;
        margin-top:-150px;
    }

    body {
        margin: 0;
        padding: 0;
        background: #fff;
        color: #fff;
        font-family: Arial;
        font-size: 12px;
    }

    .body {
        position: absolute;
        margin-left: -20.763%;
        margin-top: -1.65%;
        min-width:1925.5px;
        max-width:1925.5px;
        width: 100%;
        min-height:953.5px;
        max-height:953.5px;
        height: 100%;
        background-image: url('../img/wp_connection.jpg');
        background-size: cover;
        -webkit-filter: blur(5px);
        z-index: 0;
    }

    /* Chrome,Safari4+ */
    .grad {
        position: absolute;
        margin-left: -20.763%;
        margin-top: -1.65%;
        min-width:1925.5px;
        max-width:1925.5px;
        width: 100%;
        min-height:953.5px;
        max-height:953.5px;
        height: 100%;
        background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(0,0,0,0)), color-stop(100%,rgba(0,0,0,0.65)));
        z-index: 1;
        opacity: 0.7;
    }

    .header {
        position: absolute;
        top: calc(50% - 35px);
        left: calc(30% - 255px);
        z-index: 2;
    }

        .header div {
            float: left;
            color: #fff;
            font-family: 'Exo', sans-serif;
            font-size: 35px;
            font-weight: 200;
        }

            .header div span {
                float: left;
                color: #fff;
                font-family: 'Exo', sans-serif;
                font-size: 35px;
                font-weight: 200;
            }

    .login {
        position: absolute;
        top: calc(27.5%);
        left: calc(50% - 50px);
        min-height: 325px;
        max-height: 325px;
        height: 100%;
        z-index: 2;
    }

    .usrName {
        width: 260px;
        height: 40px;
        background: transparent;
        border: 1px solid rgba(255,255,255,0.6);
        border-radius: 2px;
        color: #fff;
        font-family: 'Exo', sans-serif;
        font-size: 16px;
        font-weight: 400;
        padding: 4px;
        text-align: center;
    }

    .usrMdp {
        width: 260px;
        height: 40px;
        background: transparent;
        border: 1px solid rgba(255,255,255,0.6);
        border-radius: 2px;
        color: #fff;
        font-family: 'Exo', sans-serif;
        font-size: 16px;
        font-weight: 400;
        padding: 4px;
        text-align: center;
    }

    .usrName:focus {
        outline: none;
        border: 1px solid rgba(255,255,255,0.9);
    }

    .usrMdp:focus {
        outline: none;
        border: 1px solid rgba(255,255,255,0.9);
    }

    .bouton {
        width: 260px;
        height: 35px;
        background: #fff;
        border: 1px solid #fff;
        cursor: pointer;
        border-radius: 2px;
        color: #a18d6c;
        font-family: 'Exo', sans-serif;
        font-size: 16px;
        font-weight: 400;
        padding: 6px;
        margin-top: 10px;
    }

        .bouton:hover {
            opacity: 0.8;
        }

        .bouton:active {
            background: #fff;
            opacity: 0.6;
        }

        .bouton:focus {
            background: #fff;
            outline: none;
        }

    ::-webkit-input-placeholder {
        color: rgba(255,255,255,0.6);
    }

    ::-moz-input-placeholder {
        color: rgba(255,255,255,0.6);
    }

    .coord {
        width: 100%;
        position: absolute;
        left:5px;
        bottom: 0px;
        vertical-align: bottom;
        z-index: 2;
        color: #fff;
        font-family: 'Exo', sans-serif;
        font-size: 20px;
        font-weight: 300;
    }
</style>

<div class="grad"></div>
<header class="header">
    <div>Gestion du registre<br /> d'identification des traitements</div>
</header>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @<div class="body">
    </div>
    @<div class="form-horizontal">
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="login">
            <div class="form-group centrerLabelNom">
                @Html.LabelFor(Function(model) model.UserName, htmlAttributes:=New With {.class = "control-label col-md-8", .style="margin-left:55px;"})
                <div class="col-md-8">
                    @Html.EditorFor(Function(model) model.UserName, New With {.htmlAttributes = New With {.class = "form-control usrName"}})
                    @Html.ValidationMessageFor(Function(model) model.UserName, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group centrerLabelMdp">
                @Html.LabelFor(Function(model) model.Password, htmlAttributes:=New With {.class = "control-label col-md-8 ", .style = "margin-left:78px;"})
                <div class="col-md-8">
                    @Html.EditorFor(Function(model) model.Password, New With {.htmlAttributes = New With {.class = "form-control usrMdp"}})
                    
                </div>

                @If ViewBag.ErreurConnection IsNot Nothing Then
                    @Html.ValidationMessageFor(Function(model) model.Password, ViewBag.ErreurConnection.ToString, New With {.class = "text-danger", .style = "width:260px;margin-left:15px;"})
                Else
                    @Html.ValidationMessageFor(Function(model) model.Password, "", New With {.class = "text-danger", .style = "width:260px;"})
                End If
            </div>

            <div class="form-group centrerBt">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Se connecter" class=" bouton" />
                </div>
            </div>
        </div>

         <div class="form-group conSel">
             @Html.RadioButton("ConType", "LDAP", True) &nbsp; LDAP
             @Html.RadioButton("ConType", "Local", False) &nbsp; Local
         </div>
    </div>
    
    @<div class="coord">
    <label>Collège : Adresse :Rue Saint-Martin, 52, 7500 Tournai Tel :003269332211</label><br/>
    <label>DPO      : Lesplingard Anaïs Email : anais.lesplingard@tournai.be Tel : 003269332416 GSM : 32475725071</label>
</div>

End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
