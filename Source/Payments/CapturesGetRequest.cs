// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// CapturesGetRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace CheckoutNetsdk.Payments
{
    /// <summary>
    /// Shows details for a captured payment, by ID.
    /// </summary>
    public class CapturesGetRequest : HttpRequest
    {
        public CapturesGetRequest(string CaptureId) : base("/v2/payments/captures/{capture_id}?", HttpMethod.Get, typeof(Capture))
        {
            try {
                this.Path = this.Path.Replace("{capture_id}", Uri.EscapeDataString(Convert.ToString(CaptureId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
