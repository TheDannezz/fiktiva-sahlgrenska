function loginButton(){
	var adminName="oopa21"
	var adminPass="1234"
	var uName =document.getElementById("username").value;
	var password=document.getElementById("Pass").value;
	if (uName ==adminName && password ==adminPass){
		alert("success");
		window.location="home.html";
		return false;
	}
}