function ClickOnTheButton(event, args) {
  var myWindow = window,
      browser = myWindow.navigator.appCodeName,
      internationalSafetyManagment = browser == "Mozilla";
      
  if(internationalSafetyManagment) {
    alert("Yes");
  } else {
    alert("No");
  }
}