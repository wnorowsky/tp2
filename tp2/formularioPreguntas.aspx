<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formularioPreguntas.aspx.cs" Inherits="Tp2.formularioPreguntas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Encuesta de Turismo"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelPregunta1" runat="server" Text="Ciudades que has visitado:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelCordoba" runat="server" Text="Cordoba"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <br />
            <asp:Label ID="LabelTucuman" runat="server" Text="Tucuman"></asp:Label>
            <asp:CheckBox ID="CheckBox2" runat="server" />
            <br />
            <asp:Label ID="LabelMendoza" runat="server" Text="Mendoza"></asp:Label>
            <asp:CheckBox ID="CheckBox3" runat="server" />
            <br />
            <asp:Label ID="LabelCatamarca" runat="server" Text="Catamarca"></asp:Label>
            <asp:CheckBox ID="CheckBox4" runat="server" />
            <br />
            <br />
            <asp:Label ID="LabelPregunta2" runat="server" Text="Según tu experiencia, volverías a visitarlas?"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelSi" runat="server" Text="Sí"></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" />
            <br />
            <asp:Label ID="LabelNo" runat="server" Text="No"></asp:Label>
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1"/>
            <br />
            <asp:Label ID="LabelQuizas" runat="server" Text="Quizás"></asp:Label>
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ver Resultados" />
            <br />
            <br />
            <asp:Label ID="mensaje" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>