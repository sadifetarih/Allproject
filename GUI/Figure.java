package hw2;

import hw2.Drawable;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

// 1 point
abstract class Figure implements Drawable, Comparable<Figure> {
	// ("x", "y") are coordinates of the "center" of the figure.
	// "counter" helps counting the number of figures.
	// Each figure has a unique "id" which can be determined through counter.
	protected int id;
	protected double x;
	protected double y;
	protected Color color;
	private static int counter;

	// 0.2 point
	// initialization
	public Figure(double x, double y, Color c) {
		// ################ COMPLETE ################
                this.x = x;
                this.y = y;
                this.color = c;
                counter++;
	}
	
	// 0.2 point
	// set counter to zero
	public static void setCounterToZero() {
		// ################ COMPLETE ################
                counter=0;
	}

	// 0.4 point
	// Compares this figure with the specified figure, based on their area
	public int compareTo(Figure fig) {
		// ################ COMPLETE ################
               if(this.getArea()< fig.getArea()){
                    return -1;
                }else if(this.getArea()>fig.getArea()){
                    return 1;
                }else
                    return 0;

	}

	// 0.2 point
	// returns string representation of this figure that 
	// contains id, x and y information
	public String toString() {
		// ################ COMPLETE ################
                return ("\nID:  "+this.id +"\nX: "+ this.x +"\nY: "+ this.y);

	}

	// draw this figure through GraphicsContext object given as argument.
	// setStroke, strokeOval and strokeRect methods of GraphicsContext may be useful.
	public abstract void draw(GraphicsContext gc);
            
	// returns true if (x, y) are coordinates inside the figure, false otherwise
	public abstract boolean isInside(double x, double y);

	// returns the area of this figure
	public abstract double getArea();

}
