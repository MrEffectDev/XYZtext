using System;

namespace xyztext.Utils
{
    public sealed class TextSearchHelper
    {
        private int _position;
        private string _currentTerm = string.Empty;

        public TextSearchHelper()
        {
            Reset();
        }

        public void Reset()
        {
            _position = 0;
            _currentTerm = string.Empty;
        }

        public int FindNext(string text, string term)
        {
            if (string.IsNullOrEmpty(term) || string.IsNullOrEmpty(text))
            {
                return -1;
            }

            if (string.Equals(_currentTerm, term, StringComparison.OrdinalIgnoreCase))
            {
                _currentTerm = term;
                _position = 0;
            }

            int index = text.IndexOf(term, _position, StringComparison.OrdinalIgnoreCase);
            if (index < 0)
            {
                _position = 0;
                return -1;
            }

            _position = index + term.Length;
            return index;
        }

        public int FindPrevious(string text, string term)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(term))
                return -1;

            if (!string.Equals(_currentTerm, term, StringComparison.OrdinalIgnoreCase))
            {
                _currentTerm = term;
                _position = text.Length;
            }

            int index = text.LastIndexOf(term, _position - 1, StringComparison.OrdinalIgnoreCase);
            if (index < 0)
            {
                _position = text.Length;
                return -1;
            }

            _position = index;
            return index;
        }
    }
}