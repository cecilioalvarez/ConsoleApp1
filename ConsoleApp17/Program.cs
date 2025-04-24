using ConsoleApp17;

Robot robot = new Robot(new BrazoRobotNormal(),"termomix");

robot.Girar();

robot.Brazo = new AdaptadorBrazo();
robot.Girar();

