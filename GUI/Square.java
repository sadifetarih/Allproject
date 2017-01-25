package hw2;

import hw2.Figure;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

// 1 point
public class Square extends Figure {

	// since both sides of a square are equal, 
	// a "width" data field is enough to store the necessary data concerning a square
	protected double width;  

	// 0.2 point
	// initialization
	public Square(double x, double y, double width, Color c) {
		// ################ COMPLETE ################
                super(x,y,c);
                super.x = x;
                super.y = y;
                this.width = width;
                super.color = c;
	}

	// 0.2 point
	// returns the area of this figure
	public double getArea() {
		// ################ COMPLETE ################
                return width*width;
	}

	// 0.2 point
	// draw this figure through GraphicsContext object given as argument
	public void draw(GraphicsContext gc) {
		// ################ COMPLETE ################
                gc.getStroke();
                gc.setStroke(color);
                gc.strokeRect(x, y, width, width);
	}

	// 0.2 point
	// returns true if (x, y) are coordinates inside the figure, false otherwise
	public boolean isInside(double x, double y) {
		// ################ COMPLETE ################
                double figurex1 = this.x;
		double figurex2 = this.x + this.width;
		double figurey1 = this.y;
		double figurey2 = this.y + this.width;
		if(x >= figurex1 && x <= figurex2 && y >= figurey1 && y <= figurey2){
			return true;
		}
		return false;
	}

	// 0.2 point
	// returns string representation of this figure that contains figure name, width,
	// and id, x and y information obtained through superclass by a method call
	public String toString() {
		// ################ COMPLETE ################
                String info = "Name: Square " + "\nWidth: " + this.width + " " + super.toString();
		return info;
	}
}
