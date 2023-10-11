const input = prompt("Enter an email address: ");

// Regular expression with capturing groups for username and domain
var emailRegex = /^([A-Za-z]{2}\d{4,5})@students\.(georgiasouthern|kennesaw|uga|gatech)\.edu$/;

var match = input.match(emailRegex);

if (match) {
    var username = match[1];
    var domain = match[2];

    alert("Username: " + username + "\nDomain: " + domain);
} else {
    alert("Invalid email address");
}