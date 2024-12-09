using System;

namespace PasswordGeneratorApp
{
    public static class StoryPlotGenerator
    {
        private static readonly string[] Settings =
        {
            "a bustling city in the year 2120",
            "a small medieval village",
            "an abandoned spaceship drifting in space",
            "a magical forest filled with ancient secrets",
            "a post-apocalyptic wasteland",
            "a parallel universe where time flows backward"
        };

        private static readonly string[] MainCharacters =
        {
            "a young orphan with mysterious powers",
            "a retired detective seeking redemption",
            "an AI who questions its own existence",
            "a rebellious teenager with a secret",
            "a warrior who lost their memory",
            "a scientist on the brink of a major discovery"
        };

        private static readonly string[] Goals =
        {
            "find their missing sibling",
            "save their homeland from destruction",
            "unlock the secrets of a forbidden artifact",
            "prevent a war between two rival factions",
            "escape a deadly trap set by their enemies",
            "bring justice to a corrupt ruler"
        };

        private static readonly string[] Conflicts =
        {
            "a shadowy organization is hunting them",
            "their closest ally betrays them",
            "a powerful villain blocks their path",
            "time is running out as the world crumbles",
            "their own fears and doubts hold them back",
            "they uncover a shocking truth about themselves"
        };

        private static readonly string[] Resolutions =
        {
            "they triumph against all odds and become a legend",
            "they make a great sacrifice to save others",
            "they fail but inspire others to continue the fight",
            "they find peace and a new purpose",
            "the conflict ends, but at a terrible cost",
            "they disappear, leaving their fate a mystery"
        };

        public static string GeneratePlot()
        {
            Random random = new Random();

            string setting = Settings[random.Next(Settings.Length)];
            string character = MainCharacters[random.Next(MainCharacters.Length)];
            string goal = Goals[random.Next(Goals.Length)];
            string conflict = Conflicts[random.Next(Conflicts.Length)];
            string resolution = Resolutions[random.Next(Resolutions.Length)];

            return $"In {setting}, {character} must {goal}. However, {conflict}. In the end, {resolution}.";
        }
    }
}
