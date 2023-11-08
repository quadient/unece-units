from lib.pint_registry import PintRegistryManager


def test_con_does_return_always_the_same_instance():
    assert PintRegistryManager() is PintRegistryManager()
    assert PintRegistryManager().get_registry() is PintRegistryManager().get_registry()

