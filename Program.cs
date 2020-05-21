using System;
using System.Globalization;
using Azure;
using Azure.AI.TextAnalytics;

namespace Cog
{
    class Program
    {

        private static readonly AzureKeyCredential credentials = new AzureKeyCredential ("3eefe592346b436184724d709cb10572");
        private static readonly Uri endpoint = new Uri ("https://eastus.api.cognitive.microsoft.com/");

        static void Main (string[] args)
        {

            var client = new TextAnalyticsClient (endpoint, credentials);
            // You will implement these methods later in the quickstart.
            //  SentimentAnalysisExample (client);
            // LanguageDetectionExample (client);
            // EntityRecognitionExample (client);
            //  EntityLinkingExample (client);
            KeyPhraseExtractionExample (client);

            Console.Write ("Press any key to exit.");
            Console.ReadKey ();
        }
        static void KeyPhraseExtractionExample (TextAnalyticsClient client)
        {
            var response = client.ExtractKeyPhrases ("Necesito Comprar un regalo para mi tia", "ES");

            // Printing key phrases
            Console.WriteLine ("Key phrases:");

            foreach (string keyphrase in response.Value)
            {
                Console.WriteLine ($"\t{keyphrase}");
            }
        }
        /* 
         static void EntityRecognitionExample (TextAnalyticsClient client)
         {
             var response = client.RecognizeEntities ("Necesito Comprar un regalo para mi tia", "ES");
             Console.WriteLine ("Named Entities:");
             foreach (var entity in response.Value)
             {
                 Console.WriteLine ($"\tText: {entity.Text},\tCategory: {entity.Category},\tSub-Category: {entity.SubCategory}");
                 Console.WriteLine ($"\t\tLength: {entity.GraphemeLength},\tScore: {entity.ConfidenceScore:F2}\n");
             }
         }
         */

    }
}