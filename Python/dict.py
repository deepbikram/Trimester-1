import json
from functools import lru_cache
import urllib.request
import urllib.parse
import urllib.error

DICTIONARY_API_BASE = "https://api.dictionaryapi.dev/api/v2/entries/en"
TIMEOUT = 5.0


@lru_cache(maxsize=512)
def is_word_in_dictionary(word: str) -> bool:
    """Return True if `word` exists in the free dictionary API, False otherwise.

    Uses only the standard library so no external dependency is required.
    """
    w = (word or "").strip().lower()
    if not w.isalpha():
        return False

    try:
        url = f"{DICTIONARY_API_BASE}/{urllib.parse.quote(w, safe='')}"
        req = urllib.request.Request(url, headers={"Accept": "application/json"})
        with urllib.request.urlopen(req, timeout=TIMEOUT) as resp:
            data = resp.read()
            if not data:
                return False
            payload = json.loads(data)
            return bool(payload)
    except urllib.error.HTTPError as e:
        # 404 = not found
        if getattr(e, 'code', None) == 404:
            return False
        return False
    except urllib.error.URLError:
        return False
