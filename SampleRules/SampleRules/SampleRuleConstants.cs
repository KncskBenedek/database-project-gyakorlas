namespace SampleRules
{
    internal static class RuleConstants
    {
        /// <summary>
        /// The name of the resources file to use when looking up rule resources
        /// </summary>
        public const string ResourceBaseName = "SampleRules.RuleResources";

        /// <summary>
        /// Lookup name inside the resources file for the select asterisk rule name
        /// </summary>
        public const string AvoidWaitForDelay_RuleName = "AvoidWaitForDelay_RuleName";
        /// <summary>
        /// Lookup ID inside the resources file for the select asterisk description
        /// </summary>
        public const string AvoidWaitForDelay_ProblemDescription = "AvoidWaitForDelay_ProblemDescription";

        /// <summary>
        /// The design category (should not be localized)
        /// </summary>
        public const string CategoryDesign = "Design";

        /// <summary>
        /// The performance category (should not be localized)
        /// </summary>
        public const string CategoryPerformance = "Design";
    }
}