namespace RubixCube.Model
{
    public sealed class RubixCubeLeftFace : RubixCubeLeftOrRightFace
    {
        internal RubixCubeLeftFace()
            : base("LeftFace.")
        {
        }

        internal RubixCubeFrontFace MoveToFront()
        {
            RubixCubeFrontFace newFace = new RubixCubeFrontFace();
            RotateAnticlockwiseThroughTop(newFace);
            return newFace;
        }

        internal RubixCubeBackFace MoveToBack()
        {
            RubixCubeBackFace newFace = new RubixCubeBackFace();
            RotateClockwiseThroughTop(newFace);
            return newFace;
        }

        internal RubixCubeTopFace MoveToTop()
        {
            RubixCubeTopFace newFace = new RubixCubeTopFace();
            RotateClockwiseThroughFront(newFace);
            return newFace;
        }

        internal RubixCubeBottomFace MoveToBottom()
        {
            RubixCubeBottomFace newFace = new RubixCubeBottomFace();
            RotateAnticlockwiseThroughFront(newFace);
            return newFace;
        }

        internal RubixCubeLeftFace RotateClockwise()
        {
            RubixCubeLeftFace newFace = new RubixCubeLeftFace();
            RotateClockwiseThroughCenterCube(newFace);
            return newFace;
        }

        internal RubixCubeLeftFace RotateAnticlockwise()
        {
            RubixCubeLeftFace newFace = new RubixCubeLeftFace();
            RotateAntiClockwiseThroughCenterCube(newFace);
            return newFace;
        }

        internal RubixCubeLeftFace Clone()
        {
            RubixCubeLeftFace newFace = new RubixCubeLeftFace();
            Clone(newFace);
            return newFace;
        }
    }
}
