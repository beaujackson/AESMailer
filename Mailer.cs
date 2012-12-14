/*
 * Created by SharpDevelop.
 * User: wjackson
 * Date: 12/13/2012
 * Time: 11:17 AM
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;

namespace AESMailer
{
	/// <summary>
	/// Description of Mailer.
	/// </summary>
	public class Mailer
	{
		public Mailer()
		{
		}

		public static Boolean SendEmail(String From, Customer customer, String Subject, String Text = null, 
		                                String HTML = null, String emailReplyTo = null, String returnPath = null)
		{
		    if (Text != null && HTML != null)
		    {
		        String from = From;
		        List<String> to = customer.Email
		            .Replace(", ", ",")
		            .Split(',')
		            .ToList();
		
				Destination destination = new Destination();
		        destination.WithToAddresses(customer.Email);
		        //destination.WithCcAddresses(cc);
		        //destination.WithBccAddresses(bcc);
		
		        Content subject = new Content();
		        subject.WithCharset("UTF-8");
		        subject.WithData(Subject);
		
		        Content html = new Content();
		        html.WithCharset("UTF-8");
		        html.WithData(HTML);
		
		        Content text = new Content();
		        text.WithCharset("UTF-8");
		        text.WithData(Text);
		
		        Body body = new Body();
		        body.WithHtml(html);
		        body.WithText(text);
		
		        Message message = new Message();
		        message.WithBody(body);
		        message.WithSubject(subject);
				        
		        string accessKey = ConfigurationManager.AppSettings["AWSAccessKey"];
		        string secretKey = ConfigurationManager.AppSettings["AWSSecretKey"];
		        
		        AmazonSimpleEmailService ses = AWSClientFactory.CreateAmazonSimpleEmailServiceClient(accessKey, secretKey);
		        SendEmailRequest request = new SendEmailRequest();
		        request.WithDestination(destination);
		        request.WithMessage(message);
		        request.WithSource(from);
		
		        if (emailReplyTo != null)
		        {
		            List<String> replyto
		                = emailReplyTo
		                .Replace(", ", ",")
		                .Split(',')
		                .ToList();
		
					request.WithReplyToAddresses(replyto);
		        }
		
		        if (returnPath != null)
		        {
		            request.WithReturnPath(returnPath);
		        }
		
		        try
		        {
		            SendEmailResponse response = ses.SendEmail(request);
		            SendEmailResult result = response.SendEmailResult;
					return true;
		        }
		        catch (Exception ex)
		        {
		            customer.ErrorMessage = ex.Message;
		            return false;
		        }
		    }
		
		    throw new Exception("Specify Text and/or HTML for the email body!");
		}		
	}
}
