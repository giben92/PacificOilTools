using PacificOilTools.Models;

public interface IServicesRepository
{
    List<Services> GetServices();
}

public class ServicesRepository : IServicesRepository
    {

  
        public List<Services> GetServices()
        {
            return new List<Services>() { new Services
            {
                Title = "Mud Logging",
                Description = "With an experience of more than 35 years providing Mud Logging services in different environments," +
                " we are aware that the opportunity to collect information during the drilling " +
                "of a well occur only once, so that our staff is trained no only to ensure that this happen but to do so in an accurate manner.",
                ImgeUrl = "/img/md-img.jpg"
            },
            new Services
            {
                Title = "Drilling Rigs Instrumentation",
                Description = " Our EDR is a state of the art technology which we can proudly affirm is the most modern and complete acquisition, " +
                "collection, storage, visualization and transmission system in the market. It can output WITSML " +
                "data up to six repositories simultaneously. Its powerful ADC of 16-bit high-speed collect data up to 100k samples per second. ",
                ImgeUrl = "/img/rt-img.jpg"
            },
            new Services
            {
                Title = "Remote Data Transmission",
                Description = " When you need to make timely decisions visualize your data wherever you are. Your data will always be protected with " +
                "the security of a 128-bit encryption And when it is not only about transmitting data but also having internet connectivity with voice IP " +
                "communication, our experts will be ready to help you.",
                ImgeUrl = "/img/parms-img.jpeg"
            },
            new Services
            {
                Title = "Advanced Formation Evaluation",
                Description = "In partnership with Intelligent Reservoir, we are able to offer its Geochemistry While Drilling by implementing mass " +
                "spectrometer, XRD and XRF.",
                ImgeUrl = "/img/slide_3.jpg"
            },
            new Services
            {
                Title = "Distributor of Hohner Sensors",
                Description = "Distributor of World Class Hohner equipment. Hohner is a manufacturer of rigs instrumentation and sensors for Mud Logging " +
                "services since 1980.  All our sensors are fully certified ATEX, (C)CSA(US), IECEx and GOST (CU) certifications. ",
                ImgeUrl = "/img/hnr_sen-img.jpg"
            }

                 };
        }
    }

