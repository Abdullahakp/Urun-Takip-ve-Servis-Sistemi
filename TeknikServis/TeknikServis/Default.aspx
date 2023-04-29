<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TeknikServis.Default" %>

<!--Author: W3layouts
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html lang="zxx">
<head>
    <title>Teknik Servis Ve Ürün Takip Sistemi</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8" />
    <meta name="keywords" content="Polaroid Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
	SmartPhone Compatible web template, free WebDesigns for Nokia, Samsung, LG, Sony Ericsson, Motorola web design" />
    <script>
        addEventListener("load", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <!-- Custom Theme files -->
    <link href="web/css/bootstrap.css" type="text/css" rel="stylesheet" media="all">
    <link href="web/css/style.css" type="text/css" rel="stylesheet" media="all">
    <!-- font-awesome icons -->
    <link href="web/css/fontawesome-all.min.css" rel="stylesheet">
    <!-- //Custom Theme files -->
    <!-- online-fonts -->
    <link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:200,300,400,600,700,900" rel="stylesheet">
    <!-- //online-fonts -->

</head>
<body>
    <div class="sidenav">
		<div class="row side_top">
		<div class="col-4 side_top_left">
			<img src="web/images/pro1.jpg" alt="news image" class="img-fluid navimg">
		</div>
		<div class="col-8 side_top_right">
			<h6>Teknik Servis </h6>
			<p>Ürün Takip</p>
		</div>
		</div>
       <header>
			<div class="container-fluid px-md-5 ">
				<nav class="mnu mx-auto">
                    <label for="drop" class="toggle">Menu</label>
                    <input type="checkbox" id="drop">
						<ul class="menu">
							<li class="active"><a href="#home" class="scroll">Ana Sayfa</a></li>
							 <li class="mt-sm-3"><a href="#about" class="scroll">Hakkımızda</a></li>
							<li class="mt-sm-3"><a href="#gallery" class="scroll">Ürünler</a></li>
							<li class="mt-sm-3"><a href="#services" class="scroll">Ürün Takibi</a></li>
							<li class="mt-sm-3"><a href="#contact" class="scroll">İletişim</a></li>
                        </ul>
				</nav>
			</div>
		</header>
    </div>
    <div class="main" id="home">
        <div class="banner-text-w3ls">
            <div class="container">
                <div class="mx-auto text-center">
                    <h1>En Ucuz Fiyatlarla En Uygun Yüzlerce 
	<br>Ürün Bir Tıkla kapınızda</h1>
					<p class="banp mx-auto mt-3">24 Farklı kategoride yüzlerce ürünle sizlerleyiz  </p>
					<a class="btn btn-primary mt-lg-5 mt-3 agile-link-bnr" href="#about" role="button">Daha Fazla</a>
                </div>
            </div>
        </div>
				<!-- about -->
<section class="slide-wrapper" id="about">
	<h3 class="w3_head mb-5">Hakkımızda</h3>
	<img src="images/1.jpg" class="img-fluid" alt="">
	<p class="iner mt-5">Bu proje Fırat Üniversitesi Yazılım Mühendisliği Bölümü Bitirme Projesi olarak yapılmıştır.Bitirme Projesi olarak kalmayacak geliştirilecek hem web tarafı için hemde mobil için arayüz yapılıp kullanıcılar ile buluşacaktır.
        Burada sizlerle en temelden başlayıp devamdı sınırlı zorluyacak bir proje yapmaktır amacımız.
        Siz değerli kullanıcılar ile beraber daha da güzel hala gelecektir.</p>
</section>
<!-- //about -->
		<!-- news -->
       <div class="news" id="gallery">
		<div class="text-center">
			<h2 class="w3_head">Ürünler</h2>
				<table class="table table-bordered">
                    <tr>
                        <th>ID</th>
                        <th>Ürün Adı</th>
                        <th>MARKA</th>
                        <th>SATIŞ Değeri</th>
                    </tr>
                    
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("ID") %></td>
                                    <td><%# Eval("AD") %></td>
                                    <td><%# Eval("MARKA") %></td>
                                    <td><%# Eval("SATISFIYAT") %></td>

                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    
                        
                    
				</table>
		</div>
			
		</div>
		
    <div class="wthree_pvtits-services align-w3" id="services">
        <div class="container">
            <div class="wthree_pvt_title text-center">
                <h3 class="w3_head">Teknik Servis
                </h3>
                <p class="main_p mb-5  text-center mx-auto">Mağazamızda almış olduğunuz ürünlerde herhangi bir teknik problem oluşursa 2 yıl süreyle herhangi bir ücret ödemeden tamir ve onarım işlemlerini yapmaktayız</p>
                <a class="btn btn-primary mt-lg-5 mt-3 agile-link-bnr" style="background-color:blueviolet" href="Webform1.Aspx" role="button">Arızalı Ürün Takip</a>
                </div>
            <div class="wthree_pvtits-services-row row">
                <div class="col-lg-4 col-md-6 wthree_sgrid py-sm-5 py-4">
                    <span class="fa fa-cog p-sm-4 p-2"></span>
                    <h4 class="my-3">Hızlı Teknik Servis </h4>
                </div>
                <div class="col-lg-4 col-md-6 wthree_sgrid  py-sm-5 py-4">
                    <span class="fa fa-refresh p-sm-4 p-2"></span>
                    <h4 class="my-3"> Arızalı Durum Sorgulama </h4>
                </div>
                <div class="col-lg-4 col-md-6 wthree_sgrid  py-sm-5 py-4">
                    <span class="fa fa-camera p-sm-4 p-2"></span>
                    <h4 class="my-3">Güvenilir Kargo</h4>
                </div>
                <div class="col-lg-4 col-md-6 wthree_sgrid   py-sm-5 py-4">
                    <span class="fa fa-bell-o p-sm-4 p-2"></span>
                    <h4 class="my-3"> 2 Yıl Ürün Garantisi</h4>
                </div>
                <div class="col-lg-4 col-md-6  wthree_sgrid  py-sm-5 py-4">
                    <span class="fa fa fa-smile-o p-sm-4 p-2"></span>
                    <h4 class="my-3">Yüzde 98 Memnuniyet</h4>
                </div>
                <div class="col-lg-4 col-md-6  wthree_sgrid   py-sm-5 py-4">
                    <span class="fa fa-plus-square-o  p-sm-4 p-2"></span>
                    <h4 class="my-3">Onlarca Kategori</h4>
                </div>
            </div>
        </div>
    </div>
    <!-- //services-->

		

<!-- contact -->
	 <section class="wedo" id="contact">
			<h3 class="w3_head mb-5">Bize Ulaşın </h3>
		   <p class="main_p mb-5  text-center mx-auto">Mağazamızda almış olduğunuz bir ürüne dair sorun olurşa bize aşağıdaki panelden mesaj atarak ulaşabilirsiniz.Mailinize en kısa sürede cönüş yapılacaktır.</p>
		   <div class="contact_grid_right mt-5 mx-auto text-center">
				<form action="#" method="post" runat="server">
					<div class="row contact_top">
						<div class="col-sm-6">
                            <asp:TextBox ID="TextBox1" runat="server" placeholder="Adınız"></asp:TextBox>
						</div>
						<div class="col-sm-6">
							 <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail"></asp:TextBox>
						</div>
					</div>	
						 <asp:TextBox ID="TextBox3" runat="server" placeholder="Konu"></asp:TextBox>
						 <asp:TextBox ID="TextBox4" runat="server" placeholder="Mesaj" TextMode="MultiLine" MaxLength="50"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />
				</form>
			</div>
			<div class="cpy-right text-center">
			<div class="follow">
				<ul class="social_section_1info">
					<li><a href="https://tr-tr.facebook.com/"><span class="fa fa-facebook"></span></a></li>
					<li><a href="https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoidHIifQ%3D%3D%22%7D"><span class="fa fa-twitter"></span></a></li>
					<li><a href="https://www.google.com.tr/?hl=tr"><span class="fa fa-google-plus"></span></a></li>
							
					<li><a href="#"><span class="fa fa-vimeo"></span></a></li>
					<li><a href="https://www.linkedin.com/feed/"><span class="fa fa-linkedin"></span></a></li>
				</ul>
			</div>
				<p>© 2022 BITIRME PROJESİ | ABDULLAH AKPINAR
					
				</p>
			</div>
	</section>
	 <!-- //contact -->

    </div>

</body>
</html>