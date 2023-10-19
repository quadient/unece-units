from lib.normalizer import Normalizer

def test_is_empty_given_empty_string_returns_true():
    assert Normalizer.is_empty('') == True
