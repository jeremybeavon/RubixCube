namespace RubixCube.Model
{
    public sealed class RubixCubeRightFace : RubixCubeLeftOrRightFace
    {
        internal RubixCubeRightFace()
            : base("RightFace.")
        {
        }

        internal RubixCubeFrontFace MoveToFront()
        {
            RubixCubeFrontFace newFace = new RubixCubeFrontFace();
            RotateClockwiseThroughTop(newFace);
            return newFace;
        }

        internal RubixCubeBackFace MoveToBack()
        {
            RubixCubeBackFace newFace = new RubixCubeBackFace();
            RotateAnticlockwiseThroughTop(newFace);
            return newFace;
        }

        internal RubixCubeTopFace MoveToTop()
        {
            RubixCubeTopFace newFace = new RubixCubeTopFace();
            RotateAnticlockwiseThroughFront(newFace);
            return newFace;
        }

        internal RubixCubeBottomFace MoveToBottom()
        {
            RubixCubeBottomFace newFace = new RubixCubeBottomFace();
            RotateClockwiseThroughFront(newFace);
            return newFace;
        }

        internal RubixCubeRightFace RotateClockwise()
        {
            RubixCubeRightFace newFace = new RubixCubeRightFace();
            RotateClockwiseThroughCenterCube(newFace);
            return newFace;
        }

        internal RubixCubeRightFace RotateAnticlockwise()
        {
            RubixCubeRightFace newFace = new RubixCubeRightFace();
            RotateAntiClockwiseThroughCenterCube(newFace);
            return newFace;
        }

        internal RubixCubeRightFace Clone()
        {
            RubixCubeRightFace newFace = new RubixCubeRightFace();
            Clone(newFace);
            return newFace;
        }
    }
}
