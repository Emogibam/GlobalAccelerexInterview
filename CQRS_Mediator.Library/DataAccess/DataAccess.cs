using Question1.CQRS_Mediator.Library.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.CQRS_Mediator.Library.DataAccess
{
    public class DataAccess : IDataAccess
    {



        public List<string> GetOpeningHours(OpeningDays request)
        {



            List<string> result = new List<string>();
            DateTime dateTime = DateTime.Today;

                string monday = "Monday: ";
            if (request.Monday != null)
            {
                foreach (var item in request.Monday)
                {
                    if (item.Type.ToLower().Trim() == "open")
                    {
                        monday += dateTime.AddSeconds(item.Value).ToString("hh tt") + "  - ";
                    }
                    else if (item.Type.ToLower().Trim() == "close")
                    {
                        monday +=  dateTime.AddSeconds(item.Value).ToString("hh tt") + ", ";
                    }
                    else if (item.Type.ToLower().Trim() != "open" && item.Type.ToLower().Trim() != "close")
                    {
                        monday += "Closed";
                    }
                }
                {
                    monday += "Closed";
                }
                result.Add(monday);
            }



            if (request.Tuesday != null)
            {
                string tuesday = "Tuesday: ";
                foreach (var item in request.Tuesday)
                {
                    if (item.Type.ToLower().Trim() == "open")
                    {
                        tuesday += dateTime.AddSeconds(item.Value).ToString("hh tt") + "  - ";
                    }
                    else if (item.Type.ToLower().Trim() == "close")
                    {
                        tuesday +=  dateTime.AddSeconds(item.Value).ToString("hh tt") + ", ";
                    }
                    else if (item.Type.ToLower().Trim() != "open" && item.Type.ToLower().Trim() != "close")
                    {
                        tuesday += "Closed";
                    }
                }
                {
                    tuesday += "Closed";
                }
                result.Add(tuesday);

            }


            if (request.Wednesday != null)
            {
                string wednesday = "Wednesday: ";
                foreach (var item in request.Wednesday)
                {
                    if (item.Type.ToLower().Trim() == "open")
                    {
                        wednesday += dateTime.AddSeconds(item.Value).ToString("hh tt") + "  - ";
                    }
                    else if (item.Type.ToLower().Trim() == "close")
                    {
                        wednesday +=  dateTime.AddSeconds(item.Value).ToString("hh tt") + " ";
                    }
                    else if (item.Type.ToLower().Trim() != "open" && item.Type.ToLower().Trim() != "close")
                    {
                        wednesday += "Closed";
                    }
                }
                {
                    wednesday += "Closed";
                }
                result.Add(wednesday);
            }



            if (request.Thursday != null)
            {
                string thursday = "Thursday: ";
                foreach (var item in request.Thursday)
                {
                    if (item.Type.ToLower().Trim() == "open")
                    {
                        thursday += dateTime.AddSeconds(item.Value).ToString("hh tt") + "  - ";
                    }
                    else if (item.Type.ToLower().Trim() == "close")
                    {
                        thursday +=  dateTime.AddSeconds(item.Value).ToString("hh tt") + " ";
                    }
                    else if (item.Type.ToLower().Trim() != "open" && item.Type.ToLower().Trim() != "close")
                    {
                        thursday += "Closed";
                    }
                }
                {
                    thursday += "Closed";
                }
                result.Add(thursday);
            }


            if (request.Friday != null)
            {
                string friday = "Friday: ";
                foreach (var item in request.Friday)
                {
                    if (item.Type.ToLower().Trim() == "open")
                    {
                        friday += dateTime.AddSeconds(item.Value).ToString("hh tt") + "  - ";
                    }
                    else if (item.Type.ToLower().Trim() == "close")
                    {
                        friday += dateTime.AddSeconds(item.Value).ToString("hh tt") + " ";
                    }
                    else if (item.Type.ToLower().Trim() != "open" && item.Type.ToLower().Trim() != "close")
                    {
                        friday += "Closed";
                    }
                }
                {
                    friday += "Closed";
                }
                result.Add(friday);
            }


            if (request.Saturday != null)
            {
                string saturday = "Saturday: ";
                foreach (var item in request.Saturday)
                {
                    if (item.Type.ToLower().Trim() == "open")
                    {
                        saturday += dateTime.AddSeconds(item.Value).ToString("hh tt") + "  - ";
                    }
                    else if (item.Type.ToLower().Trim() == "close")
                    {
                        saturday +=  dateTime.AddSeconds(item.Value).ToString("hh tt") + " ";
                    }
                    else if (item.Type.ToLower().Trim() != "open" && item.Type.ToLower().Trim() != "close")
                    {
                        saturday += "Closed";
                    }
                }
                {
                    saturday += "Closed";
                }
                result.Add(saturday);
            }



            if (request.Sunday != null)
            {
                string sunday = "Sunday: ";
                foreach (var item in request.Sunday)
                {
                    if (item.Type.ToLower().Trim() == "open")
                    {
                        sunday += dateTime.AddSeconds(item.Value).ToString("hh tt") +"  - ";
                    }
                    else if (item.Type.ToLower().Trim() == "close")
                    {
                        sunday +=   dateTime.AddSeconds(item.Value).ToString("hh tt")+ " ";
                    }
                    else if (item.Type.ToLower().Trim() != "open" && item.Type.ToLower().Trim() != "close")

                    {
                        sunday += "Closed";
                    }
                }
                {
                    sunday += "Closed";
                }
                result.Add(sunday);
            }

            return result;
        }
    }
}
