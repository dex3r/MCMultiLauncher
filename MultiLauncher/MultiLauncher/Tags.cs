using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLauncher
{
    abstract public class Tags
    {
        public readonly static string[] serverTypes = { "PvP", "PvE", "Survival (PvP + PvE)", "No PvP nor PvE", "Creative", "Other" };
        public readonly static string[] countries = { "Other", "Albania", "Algeria", "Antigua and Barbuda", "Argentina", "Australia", "Austria", "Bahrain", "Barbados", "Belarus", "Belgium", "Bosnia and Herzegovina", "Brazil", "Bulgaria", "Canada", "Chile", "China", "Colombia", "Costa Rica", "Croatia", "Cyprus", "Czech Republic", "Denmark", "Dominican Republic", "Ecuador", "Egypt", "Estonia", "Finland", "France", "Georgia", "Germany", "Greece", "Guam", "Guatemala", "Guyana", "Hong Kong", "Hungary", "India", "Indonesia", "Ireland", "Israel", "Italy", "Japan", "Jordan", "Kazakhstan", "South Korea", "Kuwait", "Latvia", "Lithuania", "Macedonia", "Malaysia", "Malta", "Mexico", "Moldova", "Morocco", "Namibia", "Netherlands", "New Zealand", "Norway", "Pakistan", "Panama", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Reunion", "Romania", "Russian Federation", "Saudi Arabia", "Serbia", "Singapore", "Slovakia", "Slovenia", "South Africa", "Spain", "Sweden", "Switzerland", "Taiwan", "Thailand", "Turkey", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Venezuela", "Vietnam" };
        public readonly static string[] states = { "Full", "Not empty", "Empty" };
        public readonly static string[] clients = { "Vanilla", "Modded" };
    }
}
