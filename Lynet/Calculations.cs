using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynet {
    public class Calculations {
        public static DateTime CalcPace(double distance, int hour, int minute) {
            // Convert time to seconds for easier calculations
            int seconds = (hour * 60 * 60) + (minute * 60);

            // Calculate pace in seconds only first
            double sec_pr_km = seconds / distance;
            // Convert to minutes
            double min_pr_km = Math.Floor(sec_pr_km / 60);
            // Subtract minutes converted to seconds to get remainder in seconds
            sec_pr_km = Math.Floor(sec_pr_km - (min_pr_km * 60));

            // Return pace as DateTime
            return new DateTime(1, 1, 1, 0, (int)min_pr_km, (int)sec_pr_km);
        }
    }
}
