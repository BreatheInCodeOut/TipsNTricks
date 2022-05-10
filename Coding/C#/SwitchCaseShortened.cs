using System;

namespace TipsAndTricks
{
    public class SwitchCaseShortened
    {
        public string GetRole()
        {
            int deptId = 0;
            string role;

            //switch (deptId)
            //{
            //    case 1:
            //        role = "UI Dev";
            //        break;
            //    case 2:
            //    case 3:
            //        role = "Backend Dev";
            //        break;
            //    case 15:
            //        role = "Q & A";
            //        break;
            //    default:
            //        role = "Not Assigned";
            //        break;
            //}

            //Available from C# 8.0

            role = deptId switch
            {
                1 => "UI Dev",
                var n when 
                    n == 2 || n == 3 => "Backend Dev",
                15 => "Q & A",
                _ => "Not Assigned"
            };

            return role;
        }
    }
}
