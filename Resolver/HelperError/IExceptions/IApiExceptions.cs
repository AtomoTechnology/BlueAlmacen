using System.Net;

namespace Resolver.HelperError.IExceptions
{
    public interface IApiExceptions
    {
        string ErrorCode { get; set; }
        /// <summary>
        /// ErrorDescription
        /// </summary>
        string MessageError { get; set; }
        /// <summary>
        /// HttpStatus
        /// </summary>
        HttpStatusCode HttpStatus { get; set; }
        /// <summary>
        /// ReasonPhrase
        /// </summary>
        string ReasonPhrase { get; set; }

        string ReferenceLink { get; set; }
    }
}
