-- Game Mechanics Script for Cat Simulator 2009

local Cat = {}

function Cat:new(name)
    local newCat = {name = name, energy = 100, hunger = 0}
    self.__index = self
    return setmetatable(newCat, self)
end

function Cat:play()
    if self.energy > 0 then
        print(self.name .. " is playing!")
        self.energy = self.energy - 10
        self.hunger = self.hunger + 5
    else
        print(self.name .. " is too tired to play.")
    end
end

function Cat:feed()
    if self.hunger > 0 then
        print(self.name .. " is being fed!")
        self.hunger = self.hunger - 10
    else
        print(self.name .. " is not hungry.")
    end
end

function Cat:rest()
    print(self.name .. " is resting...")
    self.energy = 100
end

return Cat