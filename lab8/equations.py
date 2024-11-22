import math

class Equations:
    def calculate(self, x):
        rad = x * math.pi / 180.0
        try:
            # Формула y = 1 / (2 * sin(2x))
            y = 1 / (2 * (math.sin(2 * x)))
            if rad == math.pi or rad == (math.pi * 2):
                raise Exception("Invalid : division by zero")
        except Exception as e:

            with open("error", "a") as error_file:
                error_file.write(f"Exception000999: {str(e)}\n")
            return 0
        return y
