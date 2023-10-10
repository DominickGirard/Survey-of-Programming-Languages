const input = prompt("Enter an email address: ");

// Regular expression with "students" as a required subdomain and ".edu" as a required top-level domain
var emailRegex = /^[A-Za-z]{2}\d{4,5}@students\.(georgiasouthern|kennesaw|uga|gatech)\.edu$/;

var match = input.match(emailRegex);

if (match) {
    var domain = match[1];

    alert(" Domain: " + domain);
} else {
    alert(" Invalid email address");
}