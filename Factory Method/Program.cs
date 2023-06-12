namespace Factory_Method;

interface IVehicle {
	public void Drive();
}

class Car : IVehicle {
	public void Drive() { }
}

class Bus : IVehicle {
	public void Drive() { }
}



interface IFactory {
	public IVehicle Build();
}

abstract class Factory : IFactory {
	public IVehicle Build() {
		IVehicle vehicle = CreateVehicle();
		// Some configurations
		return vehicle;
	}

	protected abstract IVehicle CreateVehicle();
}

class CarFactory : Factory {
	protected override IVehicle CreateVehicle() {
		return new Car();
	}
}

class BusFactory : Factory {
	protected override IVehicle CreateVehicle() {
		return new Bus();
	}
}



class Program {
	static void Main(string[] args) {
		IFactory factory;

		factory = new CarFactory();
		factory = new BusFactory();

		IVehicle vehicle = factory.Build();
	}
}