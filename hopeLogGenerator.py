class logHope():
    def __init__(Self, inNumber, inDescrip):
        Self.Number = str(inNumber)
        Self.Name = "\"HOPE Milestone: " + str(inNumber) + "\""
        Self.Descrip = "\"" + str(inNumber) + " HOPE produced in total. " + inDescrip + "\""
    def ToString(Self, i):
        print("logHope[" + str(i) + "] = new Log(" + Self.Name + ", " + Self.Descrip + ", " + str(Self.Number) + ");")

hopeList = []

log = logHope(10, "Producing HOPE takes up a small amount of Energy. Try not to run out...")
hopeList.append(log)
log = logHope(50, "Maybe this won't be so bad after all...")
hopeList.append(log)
log = logHope(100, "It doesn't seem like so many, but there they are...")
hopeList.append(log)
log = logHope(500, "How many more will you produce?")
hopeList.append(log)
log = logHope(1000, "Every one of them will be consumed...")
hopeList.append(log)
log = logHope(10000, "How long have you been here?")
hopeList.append(log)
log = logHope(100000, "They will never be satisfied, will they...")
hopeList.append(log)
log = logHope(1000000, "Perhaps one day you'll be able to rest...")
hopeList.append(log)
log = logHope(10000000, "How much longer can you stick it out?")
hopeList.append(log)
log = logHope(100000000, "You must be weary... Will you ever be able to stop?")
hopeList.append(log)
log = logHope(1000000000, "Why are you here, anymore? What is the point?")
hopeList.append(log)

i = 0

while i < len(hopeList):
    hopeList[i].ToString(i)
    i += 1
