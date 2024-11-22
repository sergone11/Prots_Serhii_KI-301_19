import struct

class WFile:
    def __init__(self, name):
        self.name = name

    # Запис результату в текстовий файл
    def writeResTxt(self, value):
        try:
            with open(f"{self.name}.txt", "w") as file:
                file.write(f"{value}\n")
        except Exception as e:
            print("Exception while writing in file", str(e))

    # Читання результату з текстового файлу
    def readResTxt(self):
        try:
            with open(f"{self.name}.txt", "r") as file:
                result = float(file.readline())
                return result
        except FileNotFoundError:
            print(f"Not found file {self.name}.txt")
        except Exception as e:
            print("Exception while reading file", str(e))
        return None

    # Запис результату в двійковий файл
    def writeResBin(self, value):
        try:
            with open(f"{self.name}.bin", "wb") as file:
                file.write(value.encode('utf-8'))
        except Exception as e:
            print("Exception while writing in bin file", str(e))

    # Читання результату з двійкового файлу
    def readResBin(self):
        try:
            with open(f"{self.name}.bin", "rb") as file:
                result = file.read(8)
                return result.decode('utf-8')
        except FileNotFoundError:
            print(f"Not found file {self.name}.bin")
        except Exception as e:
            print("Exception while reading file", str(e))
        return None
