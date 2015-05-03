namespace RubixCube.Model
{
    internal class RubixCubeRightFaceRotation
    {
        private readonly RubixCubeRightFace newRightFace;
        private readonly RubixCubeFrontFace oldFrontFace;
        private readonly RubixCubeFrontFace newFrontFace;
        private readonly RubixCubeTopFace oldTopFace;
        private readonly RubixCubeTopFace newTopFace;
        private readonly RubixCubeBottomFace oldBottomFace;
        private readonly RubixCubeBottomFace newBottomFace;
        private readonly RubixCubeBackFace oldBackFace;
        private readonly RubixCubeBackFace newBackFace;

        public RubixCubeRightFaceRotation(RubixCube cube, RubixCubeRightFace newRightFace)
        {
            this.newRightFace = newRightFace;
            oldFrontFace = cube.FrontFace;
            newFrontFace = oldFrontFace.Clone();
            oldTopFace = cube.TopFace;
            newTopFace = oldTopFace.Clone();
            oldBottomFace = cube.BottomFace;
            newBottomFace = oldBottomFace.Clone();
            oldBackFace = cube.BackFace;
            newBackFace = oldBackFace.Clone();
            UpdateFaces();
            RemoveOldCubes();
            AddNewCubes();
        }

        public RubixCubeFrontFace NewFrontFace
        {
            get { return newFrontFace; }
        }

        public RubixCubeTopFace NewTopFace
        {
            get { return newTopFace; }
        }

        public RubixCubeBottomFace NewBottomFace
        {
            get { return newBottomFace; }
        }

        public RubixCubeBackFace NewBackFace
        {
            get { return newBackFace; }
        }

        private void UpdateFaces()
        {
            newFrontFace.TopRightCube = newRightFace.FrontTopCube;
            newFrontFace.RightCube = newRightFace.FrontCube;
            newFrontFace.BottomRightCube = newRightFace.FrontBottomCube;
            newTopFace.BackRightCube = newRightFace.BackTopCube;
            newTopFace.RightCube = newRightFace.TopCube;
            newTopFace.FrontRightCube = newRightFace.FrontTopCube;
            newBottomFace.BackRightCube = newRightFace.BackBottomCube;
            newBottomFace.RightCube = newRightFace.BottomCube;
            newBottomFace.FrontRightCube = newRightFace.FrontBottomCube;
            newBackFace.TopRightCube = newRightFace.BackTopCube;
            newBackFace.RightCube = newRightFace.BackCube;
            newBackFace.BottomRightCube = newRightFace.BackBottomCube;
        }

        private void RemoveOldCubes()
        {
            oldFrontFace.TopRightCube.RemoveCubeWith2Faces(oldFrontFace.TopCube);
            oldFrontFace.CenterCube.RemoveCubeWith2Faces(oldFrontFace.RightCube);
            oldFrontFace.BottomRightCube.RemoveCubeWith2Faces(oldFrontFace.BottomCube);
            oldTopFace.CenterCube.RemoveCubeWith2Faces(oldTopFace.RightCube);
            oldBottomFace.CenterCube.RemoveCubeWith2Faces(oldBottomFace.RightCube);
            oldBackFace.TopRightCube.RemoveCubeWith2Faces(oldBackFace.TopCube);
            oldBackFace.CenterCube.RemoveCubeWith2Faces(oldBackFace.RightCube);
            oldBackFace.BottomRightCube.RemoveCubeWith2Faces(oldBackFace.BottomCube);
        }

        private void AddNewCubes()
        {
            newFrontFace.TopRightCube.AddCubeWith2Faces(newFrontFace.TopCube);
            newFrontFace.CenterCube.AddCubeWith2Faces(newFrontFace.RightCube);
            newFrontFace.BottomRightCube.AddCubeWith2Faces(newFrontFace.BottomCube);
            newTopFace.CenterCube.AddCubeWith2Faces(newTopFace.RightCube);
            newBottomFace.CenterCube.AddCubeWith2Faces(newBottomFace.RightCube);
            newBackFace.TopRightCube.AddCubeWith2Faces(newBackFace.TopCube);
            newBackFace.CenterCube.AddCubeWith2Faces(newBackFace.RightCube);
            newBackFace.BottomRightCube.AddCubeWith2Faces(newBackFace.BottomCube);
        }
    }
}
