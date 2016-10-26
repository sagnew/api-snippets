require 'rubygems' # not necessary with ruby 1.9 but included for completeness
require 'twilio-ruby'

# put your own credentials here
account_sid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
auth_token = 'your_auth_token'

# set up a client to talk to the Twilio REST API
@client = Twilio::REST::Client.new(account_sid, auth_token)

# Get an object from its sid. If you do not have a sid,
# check out the list resource examples on this page
@short_code = @client.account
                     .short_codes('SC6b20cb705c1e8f00210049b20b70fce3')
                     .fetch

# Update short code sms url
@short_code.update(sms_url: 'http://demo.twilio.com/docs/sms.xml')

# Print the short code
puts @short_code.short_code
