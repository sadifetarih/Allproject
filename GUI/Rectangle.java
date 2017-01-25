package hw2;

import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

// 1 point
public class Rectangle extends Square {
	// in addition to the "width" data field of a square, 
	// "height" data field is added for a rectangle.
	private double height;
        

	// 0.2 point
	// initialization
	public Rectangle(double x, double y, double width, double height, Color c) {
		// ################ COMPLETE ################
                super(x,y,width,c);
                this.height = height;
                super.width = width;
                super.x = x;
                super.y = y;
	}

	// 0.2 point
	// returns the area of this figure
	public double getArea() {
		// ################ COMPLETE ################
                return width*height;
	}

	// 0.2 point
	// draw this figure through GraphicsContext object given as argument
	public void draw(GraphicsContext gc) {
		// ################ COMPLETE ################
                gc.getStroke();
                gc.setStroke(color);
                gc.strokeRect(x, y, width, height);
	}

	// 0.2 point
	// returns true if (x, y) are coordinates inside the figure, false otherwise
	public boolean isInside(double x, double y) {
		// ################ COMPLETE ################
                double figurex1 = this.x;
		double figurex2 = this.x + this.width;
		double figurey1 = this.y;
		double figurey2 = this.y + this.height;
		if(x >= figurex1 && x <= figurex2 && y >= figurey1 && y <= figurey2){
			return true;
		}
		return false;
	}

	// 0.2 point
	// returns string representation of this figure that contains figure name, width,
	// height and id, x and y information
	public String toString() {
		// ################ COMPLETE ################
                String info = "Name: Rectangle " + "\nHeight :" + this.height + " ";
		info += "\nWidth: " + this.width + "\nID: " + this.id + "\nX: " + this.x + "\nY: " + this.y;
		return info;

	}
}
