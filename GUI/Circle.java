package hw2;

import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

// 1 point
public class Circle extends Figure {

	private double radius;

	// 0.2 point
	// initialization
	public Circle(double x, double y, double radius, Color c) {
		// ################ COMPLETE ################
                super(x,y,c);
                super.x = x;
                super.y = y;
                super.color = c;
                this.radius = radius;
	}

	// 0.2 point
	// returns the area of this figure
	public double getArea() {
		// ################ COMPLETE ################
                return Math.PI * radius * radius;
	}

	// 0.2 point
	// draw this figure through GraphicsContext object given as argument
	public void draw(GraphicsContext gc) {
		// ################ COMPLETE ################
                gc.getStroke();
                gc.setStroke(color);
                gc.strokeOval(x, y, radius, radius);
	}

	// 0.2 point
	// returns true if (x, y) are coordinates inside the figure, false otherwise
	public boolean isInside(double x, double y) {
		// ################ COMPLETE ################
                double x1 = this.x;
                double x2 = this.x + 2*(this.radius);
                double y1 = this.y;
		double y2 = this.y + 2*(this.radius);
                if(x >= x1 && x <= x2 && y >= y1 && y <= y2){
			return true;
		}
		return false;
	}

	// 0.2 point
	// returns string representation of this figure that contains figure name, radius, 
	// and id, x and y information obtained through superclass by a method call
	@Override
	public String toString() {
		// ################ COMPLETE ################
                String info = "Name: Circle" + "\nRadius: " + this.radius + " ";
                info += super.toString();
                return info;
	}
}
