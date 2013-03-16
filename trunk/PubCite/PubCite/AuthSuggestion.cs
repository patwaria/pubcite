using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG
{
    public class AuthSuggestion
    {
        List<string> suggestions;
        List<string> suggestionURL;
        bool suggest;


        public AuthSuggestion(List<string> s, List<string> u, bool suggest)
        {
            this.suggest = suggest;
            if (isSet())
            {
                this.suggestions = s;
                this.suggestionURL = u;
            }
        }
        public List<String> getSuggestions()
        {
            return suggestions;
        }
        public List<string> getSuggestionsURL()
        {
            return suggestionURL;
        }
        public bool isSet()
        {
            return suggest;
        }
    }
}
