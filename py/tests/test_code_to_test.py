import pytest
from code_to_test import is_even
from code_to_test import divide


def test_if_number_is_even():
    assert is_even(2) is True


def test_divide_throws_exception():
    with pytest.raises(ZeroDivisionError, match='division by zero'):
        divide(10, 0)
