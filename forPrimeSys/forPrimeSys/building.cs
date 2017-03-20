using System;

class Building
{
    public string buildingName;
    public int floors; //numbers of floors;
    public int area;    //total square footage of building
    public int occupants;//number of occupants

    //factory application
    /*public static Building CreateBuilding(string buildingName, int floors, int area, int occupants) { // don't use constructor when using this.
        Building newBuilding = new Building();

        newBuilding.buildingName = buildingName;
        newBuilding.floors = floors;
        newBuilding.area = area;
        newBuilding.occupants = occupants;

        return newBuilding;
    }
    public void ShowHouseInfo() {

        Console.WriteLine("{0}+{1}+{2}+{3}", buildingName, floors, area, occupants);

    }*/

    
    public Building()
    { //constructor, forced to set default
    }

    public Building(string buildingName, int floors, int area, int occupants)
    { //constructor, forced to set default
        this.buildingName = buildingName;
        this.floors = floors;
        this.area = area;
        this.occupants = occupants;
  
    }

    public Building(int floors, int area): this("defaultName",floors, area, 5)  {

    }
    public void setBuildingName(string buildingName = "whateverBuildingItIs", int floors = 2, int area = 3)
    { //constructor, forced to set default
        this.buildingName = buildingName;
        this.floors = floors;
        this.area = area;
    }

    ~Building() {//destructor, runs before the instance object is gabage collected.
    }

    public string areaPerPerson() {
        return (occupants == 0) ? "No one lives here." : (area / occupants).ToString();
    }


    public void addOccupants(int i)
    {
        occupants += i;
    }

    public static void swapHouse(ref Building house1, ref Building house2)
    {
        Building tempHouse;
        tempHouse = house1;
        house1 = house2;
        house2 = tempHouse;
    }
    public static void combine(out Building combinedHouse, params Building[] houses)
    {
        combinedHouse = new Building();
        if (houses.Length == 0) {
            Console.WriteLine("no houses to combine."); 
            return;
        }
        combinedHouse.buildingName = "combinedHouse";

        foreach (Building b in houses)
        {
            combinedHouse.floors += b.floors;
            combinedHouse.area += b.area;
            combinedHouse.occupants += b.occupants;
        }
    }

    public static Building operator +(Building a, Building b) {
        Building result = new Building(a.buildingName, a.floors, a.area, a.occupants);
        result.buildingName = "combined Household of "+ a.buildingName + " and " + b.buildingName;
        result.floors = a.floors + b.floors;
        result.area = a.area + b.area;
        result.occupants = a.occupants + b.occupants;
        return result;
    }

    public static Building operator -(Building a, int occupants)
    {
        Building result = new Building(a.buildingName, a.floors, a.area, a.occupants);
        result.occupants = (a.occupants >= occupants) ? a.occupants - occupants : 0;
        return result;
    }

    public static Building operator ++(Building a)
    {
        Building result = new Building(a.buildingName, a.floors, a.area, a.occupants);
        result.occupants = a.occupants + 1;
        return result;
    }

    public static Building operator --(Building a)
    {
        Building result = new Building(a.buildingName, a.floors, a.area, a.occupants);
        result.occupants = a.occupants - 1;
        return result;
    }

    public static implicit operator int(Building a)
    {
        return 100;
    }

    public static explicit operator car(Building a)
    {
        car beetle = new car();
        beetle.carName = a.buildingName + "turned to a car";
        beetle.myFloors = a.floors;
        beetle.area = a.area;
        beetle.occupantsN = a.occupants;

        return beetle;
    }

}

class car
{
    public string carName;
    int floors;  //numbers of floors;
    public int area;    //total square footage of building
    public int occupantsNum { get; private set; }//number of occupants , private set makes it read only
    public occupants occupantsInfo;


    public int occupantsN
    {
        set
        {
            occupantsNum = value;
        }
    }

    public int myFloors {
        get {
            return floors;
        }
        set {
            if (value > 0 && value < 5) floors = value;
            else Console.WriteLine(value +" is invalid floor number.");
        }

    }

    public car() { }

    public car(string carName, int floors, int area, int occupantsNum) {
 
        this.carName = carName;
        this.area = area;
        this.floors = floors;
        this.occupantsNum = occupantsNum;
        occupantsInfo = new occupants(5); //create group, set array size to 5 occupants
        int x;

        for (int i = 0; i < occupantsInfo.occupantsNum; i++)
        {
            occupantsInfo[i] = i * 10; //set all 5 occupants' age 
        }
        for (int i = 0; i < occupantsInfo.occupantsNum; i++)
        {
            x = occupantsInfo[i];
            if (x != -1) Console.Write(x + " ");
        }
        Console.WriteLine();
    }


}

class occupants {
    int[] occupantsAgeClutter;
    int occupantsNumber;
    public bool errorFlag;
    public occupants(int size)
    {
        occupantsAgeClutter = new int[size];
        occupantsNumber = size;
    }

    public int occupantsNum
    {
        get
        {
            return occupantsNumber;
        }
        set
        {
            if (value >= 0 && value <= 4)
                occupantsNumber = value;
        }      
    }

    bool rangeCheck(int index) {
        if (index >= 0 && index < occupantsNumber) return true;
        else return false;
    }

    public int this[int index]
    {
        get
        {
            if (rangeCheck(index))
            {
                errorFlag = false;
                return occupantsAgeClutter[index];
            }
            else
            {
                errorFlag = true;
                return -1;
            }
        }
        set {
            if (rangeCheck(index))
            {
                occupantsAgeClutter[index] = value;
                errorFlag = false;
            }
            else errorFlag = true;
        }
    }

}

