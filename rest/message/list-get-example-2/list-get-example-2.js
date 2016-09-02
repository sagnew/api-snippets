// Download the Node helper library from twilio.com/docs/node/install
// These vars are your accountSid and authToken from twilio.com/user/account
var accountSid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX';
var authToken = "your_auth_token";
var client = require('twilio')(accountSid, authToken);

// TODO: Add To, From, DateSent> parameters
client.messages.list(function(err, data) {
    data.messages.forEach(function(message) {
        console.log(message.body);
    });
});