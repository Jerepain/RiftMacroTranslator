<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">

    <%-- <% using (Html.BeginForm("HandleForm", "Home")) %>
    <% { %>
    <%= Html.TextArea("macro", null, new {@cols="10" , @rows="10" }) %>
    <br />

    <%= %>
    <input type="submit" value="Traduire" />
    <p style="white-space: pre-line">
        <%= ViewBag.traduit %>
    </p>
    <% } %>
   

    <% Html.RadioButton("french", "French"); %>
    <% Html.RadioButton("german", "German"); %>--%>
    <%--
    <script>
        function loadXMLDoc() {
            var xmlhttp;
            if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
                xmlhttp = new XMLHttpRequest();
            }
            else {// code for IE6, IE5
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    document.getElementById("myDiv").innerHTML = xmlhttp.responseText;
                }
            }
            xmlhttp.open("GET", "Resources/ajax_info.txt", true);
            xmlhttp.send();
        }
    </script>
    <div id="myDiv">
        <h2>Let AJAX change this text</h2>
    </div>
    <button type="button" onclick="loadXMLDoc()">Change Content</button>

    --%>






    <span>Type your macro, for example : cast fiery burst</span>

    <table>
        <tr>
            <td>
                <% using (Ajax.BeginForm("Translate", new AjaxOptions { UpdateTargetId = "textEntered", LoadingElementId = "divProcessing" }))
                   { %>
                <%= Html.TextArea("textBox1", null, new {@cols="10" , @rows="20" })%>
            </td>
            <td>
                <%= Html.DropDownList("language",new List<SelectListItem>{new SelectListItem(){Selected = false,Text = "french", Value = "fr-FR"}, new SelectListItem(){Selected = false,Text = "deutsch", Value = "de-DE"}}) %>
             
                <input type="submit" value="Translate" id="process" />
            </td>
            <td>
                <%= Html.TextArea("textEntered", null, new {@cols="10" , @rows="20" }) %>
            </td>
        </tr>
    </table>
    <div id="divProcessing" style="display: none;">
        <img src="http://i.imgur.com/bvaKfDm.gif" />
    </div>
    <% } %>





    <%--  
      <script type="text/javascript">

          $(document).ready(function () {

              // Hide the "busy" Gif at load:
              $("#divProcessing").hide();

              // Attach click handler to the submit button:
              $('#process').click(function () {
                  $('#myform').submit();
              });

              // Handle the form submit event, and make the Ajax request:
              $("#myform").on("submit", function (event) {
                  event.preventDefault();

                  // Show the "busy" Gif:
                  $("#divProcessing").show();
                  var url = $(this).attr("action");
                  var formData = $(this).serialize();
                  $.ajax({
                      url: url,
                      type: "POST",
                      data: formData,
                      dataType: "json",
                      success: function(resp) {

                          // Hide the "busy" gif:
                          $("#divProcessing").hide();

                          // Do something useful with the data:
                          //$("<h3>" + resp.FirstName + " " + resp.LastName + "</h3>").appendTo("#divResult");
                      }
                  });
              });
          });

  </script>--%>
</asp:Content>
