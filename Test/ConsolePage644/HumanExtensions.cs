﻿namespace MyExtensions {
    public static class HumanExtensions {
        public static bool IsDistressCall(this string s) {
            if (s.Contains("Help!"))
                return true;
            else
                return false;
        }
    }
}

