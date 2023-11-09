from typing import Optional

from pint import UnitRegistry


class PintRegistryManager:
    _instance: Optional['PintRegistryManager'] = None

    def __new__(cls):
        if cls._instance is None:
            cls._instance = super().__new__(cls)
            cls._instance.registry = PintRegistryManager.__create_registry()
        return cls._instance

    def get_registry(self) -> UnitRegistry:
        return self.registry

    @staticmethod
    def __create_registry() -> UnitRegistry:
        registry = UnitRegistry()
        registry.define("E = 1 erlang = E")
        registry.define("R = 1 roentgen = R")
        registry.define("dec = 1 decade = dec")
        registry.define('shannon = 1 Sh = Sh')
        registry.define('hartley = 1 Hart = Hart')
        registry.define('parts_per_billion_US = 1 ppb = ppb')
        registry.define("beats_per_minute = 1 BPM = BPM")
        registry.define("month = 1 mo = mo")
        registry.define("Nm = newton * meter = N * m")
        registry.case_sensitive = True
        return registry
