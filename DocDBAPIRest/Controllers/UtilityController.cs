using System;
using System.Web.Http;

namespace DocDBAPIRest.Controllers
{
    public class UtilityController : ApiController
    {
        /// <summary>
        /// Converts DateTime to double
        /// </summary>
        /// <param name="value">DateTime</param>
        /// <returns></returns>
        public double ConvertToTimestamp(DateTime value)
        {
            //create Timespan by subtracting the value provided from
            //the Unix Epoch
            var span = (value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime());

            //return the total seconds (which is a UNIX timestamp)
            return span.TotalSeconds;
        }
    }
}
